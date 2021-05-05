using System;

namespace SortingCustomerComponent.Contracts.Events
{
    public class DomainAssigned
    {
        public Guid Id { get; set; }
        public string Domain { get; set; }
    }
}