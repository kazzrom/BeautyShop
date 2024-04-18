using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class RegistrationService
    {
        public long Id { get; set; }
        public string Date { get; set; } = null!;
        public long ClientId { get; set; }
        public long ScheduleItemId { get; set; }

        public virtual EmployeeSchedule ScheduleItem { get; set; } = null!;
    }
}
