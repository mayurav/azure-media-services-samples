using System;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using System.Linq;
using System.Net;
using Microsoft.Practices.TransientFaultHandling;
using Microsoft.WindowsAzure.MediaServices.Client.TransientFaultHandling;

namespace MediaServicesCustomMediaRetryPolicy
{
    public class TestSaveChangesErrorDetectionStrategy : SaveChangesErrorDetectionStrategy
    {
        //created a new detectionstrategy for savecanges to add timeoutexception in the transient exception list.
        protected override bool CheckIsTransient(Exception ex)
       {
            if (IsTimeoutException(ex))
            {
                return true;
            }

            return base.CheckIsTransient(ex);

        }
    }
}



