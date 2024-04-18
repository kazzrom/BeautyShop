using System;
using System.Collections.Generic;

namespace BeautyShop.Models
{
    public partial class EmployeeSchedule
    {
        public EmployeeSchedule()
        {
            RegistrationServices = new HashSet<RegistrationService>();
        }

        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long ServiceId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;

        public virtual ICollection<RegistrationService> RegistrationServices { get; set; }
    }
}
