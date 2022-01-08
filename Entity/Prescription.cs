using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Entity
{
    public class Prescription
    {
        [Column(TypeName = "varchar(40)")]
        [Key]

        public Guid Id { get; set; }
        [Column(TypeName = "varchar(40)")]
        public Guid? IdSchedule { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double TimeStamp { get; set; }
    }
}
