using Microsoft.Practices.TransientFaultHandling;
using Microsoft.WindowsAzure.MediaServices.Client;
using Microsoft.WindowsAzure.MediaServices.Client.TransientFaultHandling;
using System;
using System.Configuration;
using System.IO;

namespace MediaServicesCustomMediaRetryPolicy
{
    public class TestAzureMediaServicesClassFactory : AzureMediaServicesClassFactory
    {
        private const int ConnectionBlobMaxAttempts = 5;
        private const int ConnectionSaveRetryMaxAttempts = 3;
        private const int ConnectionQueryRetryMaxAttempts = 2;
        private const int ConnectionRetryInitialInterval = 200;
        private const int ConnectionRetrySleepQuantum = 100;
        public TestAzureMediaServicesClassFactory(Uri mediaServicesUri, CloudMediaContext mediaContext)
            : base(mediaServicesUri, mediaContext)
        {

        }
        /// <summary>
        /// Creates retry policy for working with Azure blob storage.
        /// This overrides the GetBlobStorageClientRetryPolicy defined in AzureMediaServicesClassFactory
        /// </summary>
        /// <returns>Retry policy.</returns>
        public override MediaRetryPolicy GetBlobStorageClientRetryPolicy()
        {
            //overriding the retry policy to have 5 retry attempts for working with Azure blob storage.
            var retryPolicy = new MediaRetryPolicy(
                GetStorageTransientErrorDetectionStrategy(),
                ConnectionBlobMaxAttempts);

            return retryPolicy;
        }

        /// <summary>
        /// Creates retry policy for saving changes in Media Services REST layer.
        /// This overrides the GetSaveChangesRetryPolicy defined in AzureMediaServicesClassFactory
        /// </summary>
        /// <returns>Retry policy.</returns>
        public override MediaRetryPolicy GetSaveChangesRetryPolicy(IRetryPolicyAdapter adapter)
        {
            //Overriding to create a retrypolicy with a different RetryInitialInterval and retrycount than the default one.
            //Also creating a new custom retrystrategy 
            var retryPolicy = new MediaRetryPolicy(
                GetSaveChangesErrorDetectionStrategy(),
                retryCount: ConnectionSaveRetryMaxAttempts,
                initialInterval: TimeSpan.FromMilliseconds(ConnectionRetryInitialInterval),
                increment: TimeSpan.FromMilliseconds(ConnectionRetrySleepQuantum * 16)
                );
            retryPolicy.RetryPolicyAdapter = adapter;
            return retryPolicy;
        }

        /// <summary>
        /// Creates retry policy for querying Media Services REST layer.
        /// This overrides the GetQueryRetryPolicy defined in AzureMediaServicesClassFactory
        /// </summary>
        /// <returns>Retry policy.</returns>
        public override MediaRetryPolicy GetQueryRetryPolicy(IRetryPolicyAdapter adapter)
        {
            //Overriding to create a retrypolicy that has different retryattempts and retrysleepquantum than the default one.
            var retryPolicy = new MediaRetryPolicy(
                GetQueryErrorDetectionStrategy(),
                (RetryStrategy)new FixedInterval(ConnectionQueryRetryMaxAttempts, TimeSpan.FromMilliseconds((ConnectionRetrySleepQuantum))));
            retryPolicy.RetryPolicyAdapter = adapter;
            return retryPolicy;
        }

        /// <summary>
        /// Creates error detection strategy that can be used for detecting transient errors when SaveChanges() is invoked.
        /// </summary>
        /// <returns>Error detection strategy.</returns>
        public override MediaErrorDetectionStrategy GetSaveChangesErrorDetectionStrategy()
        {
            //This calls the custom retrystrategy that we created.
            return new TestSaveChangesErrorDetectionStrategy();
        }
    }
}
