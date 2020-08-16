using Acme.Account.Core.Interfaces;
using Acme.Account.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Account.Core.Queries.Customer
{
    internal class CustomerQuery : ICustomerQuery
    {
        private readonly IRepository<CustomerModel> _repository;
        
        public CustomerQuery(IRepository<CustomerModel> repository)
        {
            _repository = repository;
        }
        public async Task<CustomerModel> Get(Func<CustomerModel, bool> query)
        {
            var customer = await _repository.GetAllAsync();

            return customer.Where(query).FirstOrDefault();
        }

        public Task<IEnumerable<CustomerModel>> GetAll()
        {
            return _repository.GetAllAsync();
        }
    }
}
