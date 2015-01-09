using System.Linq;
using Microsoft.Practices.TransientFaultHandling;
using Microsoft.WindowsAzure.MediaServices.Client;
using Microsoft.WindowsAzure.MediaServices.Client.TransientFaultHandling;
using System;
using System.Configuration;
using System.IO;
namespace MediaServicesCustomMediaRetryPolicy
{
    class Program
    {
        // Paths to support files (within the above base path). You can use 
        // the provided sample media files from the "SupportFiles" folder, or 
        // provide paths to your own media files below to run these samples.

        private static readonly string _mediaFiles =
            Path.GetFullPath(@"../..\Media");

        private static readonly string _singleMP4File =
            Path.Combine(_mediaFiles, @"SingleMP4\BigBuckBunny.mp4");
        private static CloudMediaContext _context = null;

        // Media Services account information.
        public static readonly string MediaServicesAccountName =
            ConfigurationManager.AppSettings["MediaServiceAccountName"];
        public static readonly string MediaServicesAccountKey =
            ConfigurationManager.AppSettings["MediaServiceAccountKey"];
        public static string MediaServicesUri = ConfigurationManager.AppSettings["MediaServicesUri"];
        public static string MediaServicesAcsBaseAddress = ConfigurationManager.AppSettings["MediaServicesAcsBaseAddress"];
        public static string MediaServicesAccessScope = ConfigurationManager.AppSettings["MediaServicesAccessScope"];
        private static void Main(string[] args)
        {

            _context = new CloudMediaContext(new Uri(MediaServicesUri),
                new MediaServicesCredentials(MediaServicesAccountName, MediaServicesAccountKey, MediaServicesAccessScope,
                    MediaServicesAcsBaseAddress));
            // Use this constructor for creating a custom AzureMediaServicesClassFactory and assigning it to the mediacontext.
            _context.MediaServicesClassFactory = new TestAzureMediaServicesClassFactory(new Uri(MediaServicesUri),
                _context);

            var assetName = "testCustomRetryPolicy";

            //Uses GetSaveChangesRetryPolicy defined by TestAzureMediaServicesClassFactory 
            var asset = _context.Assets.Create(assetName, AssetCreationOptions.None);

            var fileName = Path.GetFileName(_singleMP4File);

            var assetFile = asset.AssetFiles.Create(fileName);
            var accessPolicy = _context.AccessPolicies.Create(assetName, TimeSpan.FromDays(30),
                                                                AccessPermissions.Write | AccessPermissions.List);
            var locator = _context.Locators.CreateLocator(LocatorType.Sas, asset, accessPolicy);
            Console.WriteLine("Upload {0}", assetFile.Name);

            //This uses GetBlobStorageClientRetryPolcy defined by TestAzureMediaServicesClassFactory
            assetFile.Upload(_singleMP4File);
            Console.WriteLine("Done uploading {0}", assetFile.Name);

            //This uses GetQueryRetryPolcy defined by TestAzureMediaServicesClassFactory
            assetFile = asset.AssetFiles.First();
            Console.WriteLine("AssetFile Found is {0}",assetFile.Name);
            
            locator.Delete();
            accessPolicy.Delete();

        }    

    }
}
