using Cibertec.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using Cibertec.Repositories.Northwind;

namespace Cibertec.Repositories.Dapper.Northwind
{
    public class NorthwindUnitOfWork : IUnitOfWork

    {
        public NorthwindUnitOfWork(string connectioString)
        {
            Customers = new CustomerRepository(connectioString);
            Orders = new OrderRepository(connectioString);
            /*
            OrderItems = new CustomerRepository(connectioString);
            Products = new CustomerRepository(connectioString);
            Suppliers = new CustomerRepository(connectioString);
            Users = new CustomerRepository(connectioString);
            */
        }
        public ICustomerRepository Customers { get; private set; }

        public IOrderRepository Orders { get; private set; }

        public IOrderItemRepository OrderItems { get; private set; }

        public IProductRepository Products { get; private set; }

        public ISupplierRepository Suppliers { get; private set; }

        public IUserRepository Users { get; private set; }
    }
}
