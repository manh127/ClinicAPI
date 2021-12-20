using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Request
{
    public class CreateScheduleRequest
    {
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public long DateTimeStamp { get; set; }
        public Guid ServiceId { get; set; }

    }
}
