using Acme.Account.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acme.Account.Core.Queries.Customer
{
    public interface ICustomerQuery
    {
        Task<IEnumerable<CustomerModel>> GetAll();

        Task<CustomerModel> Get(Func<CustomerModel, bool> query);
    }
}
