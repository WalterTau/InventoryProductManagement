using CashCrusadersFranchising.API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashCrusadersFranchising.API.Config
{
    public class SQLServerSettings : ISQLServerSettings
    {
        private ServiceApiConfiguration ServiceApiConfiguration;

        public SQLServerSettings(ServiceApiConfiguration serviceApiConfiguration)
        {
            ServiceApiConfiguration = serviceApiConfiguration;
        }

        public string ConnectionString { get => ServiceApiConfiguration.SQLConnectionString; }

        public string DatabaseName { get => ServiceApiConfiguration.DatabaseName; }

        public string ProductEntity { get => ServiceApiConfiguration.Entities?.Product; } 

        public string SuppliersEntity { get => ServiceApiConfiguration.Entities.Suppliers; }

        public string UsersEntity { get => ServiceApiConfiguration.Entities.Users; } 

        public string PurchaseOrderEntity { get => ServiceApiConfiguration.Entities.PurchaseOrder; } 
    }
}
