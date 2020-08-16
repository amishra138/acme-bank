using Acme.Account.Core.Command.Customer;
using Acme.Account.Core.Queries.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Acme.Account.API.Controllers
{
    /// <summary>
    /// Customer 
    /// </summary>
    public class CustomerController : BaseController<CustomerController>
    {
        private readonly ICustomerQuery _customerQuery;
        public CustomerController(ICustomerQuery customerQuery)
        {
            _customerQuery = customerQuery;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customer = await _customerQuery.GetAll();
            return Ok(customer);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customer = await _customerQuery.Get(x => x.Id == id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerRequest request)
        {
            return await Request(request);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerRequest request)
        {
            return await Request(request);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(DeleteCustomerRequest request)
        {
            return await Request(request);
        }
    }
}
