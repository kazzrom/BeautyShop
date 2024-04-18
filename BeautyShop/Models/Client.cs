using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class Client
    {
        public Client()
        {
            Guestbooks = new HashSet<Guestbook>();
        }

        public long Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long IsConstant { get; set; }

        public virtual ICollection<Guestbook> Guestbooks { get; set; }
    }
}
