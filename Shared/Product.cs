using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamersdomain.Shared
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Category { get; set; }
        //public string? ImageUrl { get; set; }
        [Column(TypeName ="decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
