using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class Service
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public long Price { get; set; }
        public string TypeService { get; set; } = null!;

        public virtual NamesService NameNavigation { get; set; } = null!;
        public virtual TypesService TypeServiceNavigation { get; set; } = null!;
    }
}
