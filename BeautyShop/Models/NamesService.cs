using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class NamesService
    {
        public NamesService()
        {
            Services = new HashSet<Service>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Service> Services { get; set; }
    }
}
