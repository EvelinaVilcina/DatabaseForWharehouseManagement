using System;
using System.Collections.Generic;
using System.Text;
    
namespace DatabaseForWharehouseManagement.Models
{
    public class Client
    {
#nullable enable
        public int ClientId { get; set; }
        public string? FullName { get; set; }

        public int AddressId { get; set; }

        public Address? Address { get; set; }

        public string? PhoneNumber { get; set; }

#nullable disable
    }
}
