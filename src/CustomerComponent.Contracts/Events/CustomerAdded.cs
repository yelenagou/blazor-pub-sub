using System;

namespace CustomerComponent.Contracts.Events
{
    public class CustomerAdded
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
