using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseForWharehouseManagement.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }
        public short ColourCode { get; set; }
        public string EanCode { get; set; }
        public int Stock { get; set; }
        public bool IsOutOfStock { get; set; }
    }
}
