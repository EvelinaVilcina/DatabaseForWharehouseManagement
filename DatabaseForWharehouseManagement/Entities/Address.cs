using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseForWharehouseManagement.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string StreetName { get; set; }

        public string HouseName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public short Zip { get; set; }
    }
}
