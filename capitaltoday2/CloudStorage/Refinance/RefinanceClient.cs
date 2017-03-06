using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace capitaltoday2.CloudStorage.Refinance
{
    public class RefinanceClient : TableStorageClient<Refinance>
    {
        public RefinanceClient() : base("Refinance") { }
    }
}