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
        public bool IsConstant { get; set; }

        public string Fullname {
            get => $"{Surname} {Name} {Patronymic}";
        }

        public virtual ICollection<Guestbook> Guestbooks { get; set; }
    }
}
