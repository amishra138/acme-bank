using Acme.Account.Core.Command.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Acme.Account.API.Controllers
{
    /// <summary>
    /// Customer 
    /// </summary>
    public class CustomerController : BaseController<CustomerController>
    {
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
