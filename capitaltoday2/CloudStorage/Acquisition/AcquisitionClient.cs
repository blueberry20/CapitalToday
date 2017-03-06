using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace capitaltoday2.CloudStorage.Acquisition
{
    public class AcquisitionClient : TableStorageClient<Acquisition>
    {
        public AcquisitionClient() : base("Acquisition") { }
    }
}