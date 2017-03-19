using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage.Table;

namespace capitaltoday2.CloudStorage.Acquisition
{
    public class Acquisition : TableEntity
    {
        public Acquisition()
        {
            PartitionKey = "Acquisition";
            RowKey = Guid.NewGuid().ToString();
        }

        public string PurchasePrice { get; set; }
        public string RequestedLoanAmount { get; set; }
        public string PropertyType { get; set; }
        public string UnitNumber { get; set; }
        public string OtherDescription { get; set; }
        public string PropertyState { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}