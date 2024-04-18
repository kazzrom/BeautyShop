using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Post { get; set; } = null!;
    }
}
