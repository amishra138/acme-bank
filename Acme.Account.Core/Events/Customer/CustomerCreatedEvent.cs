using Acme.Account.Core.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Account.Core.Events.Customer
{
    public class CustomerCreatedEvent : INotification
    {
        public CustomerModel Customer { get; private set; }

        public CustomerCreatedEvent(CustomerModel customer)
        {
            Customer = customer;
        }
    }

    public class CustomerCreatedEventHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public async Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.Customer.FirstName);
        }
    }
}
