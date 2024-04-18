using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class Guestbook
    {
        public long CommentId { get; set; }
        public string Comment { get; set; } = null!;
        public long ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
