using CashCrusadersFranchising.Api.Data;
using CashCrusadersFranchising.API.Config;
using CashCrusadersFranchising.API.Service;
using CashCrusadersFranchising.API.Service.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashCrusadersFranchising.API
{
    public static class ServiceRegistrationExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
        
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISuppliersService, SuppliersService>();
            services.AddTransient<IUsers, UsersService>();
            services.AddTransient<IEmployeesService, EmployeesService>();
            services.AddTransient<IPurchaseOrdersService, PurchaseOrdersService>();
        }
    }
}
