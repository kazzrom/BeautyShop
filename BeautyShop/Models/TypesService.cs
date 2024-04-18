using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class TypesService
    {
        public string Name { get; set; } = null!;

        public virtual Service? Service { get; set; }
    }
}
