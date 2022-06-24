using System;
using System.Collections.Generic;

namespace UsingLinq.Models
{
    public partial class NewCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
    }
}
