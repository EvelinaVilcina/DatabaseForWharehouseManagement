using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseForWharehouseManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderNumber { get; set; }

        public DateTime DateTime { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public List<Product> Products { get; set; }
    }
}
