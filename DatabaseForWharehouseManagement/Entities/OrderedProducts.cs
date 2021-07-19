using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseForWharehouseManagement.Entities
{
    public class OrderedProducts
    {
        [Key]
        public int OrderedProductId { get; set; }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string OrderNumber { get; set; }
    }
}
