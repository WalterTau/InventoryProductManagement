using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashCrusadersFranchising.API.Config
{
    public class ServiceApiConfiguration
    {
        public string SQLConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public SQLServerDBEntities Entities { get; set; }
    }

    public class SQLServerDBEntities
    {
        public string Users { get; set; }
        public string Product { get; set; }
        public string PurchaseOrder { get; set; }
        public string Suppliers { get; set; }
    }
}
