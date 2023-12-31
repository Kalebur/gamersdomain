﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gamersdomain.Shared
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        [JsonIgnore]
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        [Column(TypeName ="decimal(18, 2)")]
        public decimal Price { get; set; }
        public bool IsFeaturedProduct { get; set; } = false;
    }
}
