using MotorHomepage.Data.Enums;
using MotorHomepage.Data.Interfaces;
using MotorHomepage.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorHomepage.Data.Entities
{
    [Table("SysDictionnary")]
    public class SysDictionary : DomainEntity<int>, ISwitchable, IDateTracking, IHasSoftDelete
    {
        [MaxLength(1000)]
        public string Language1 { get; set; }
        [MaxLength(1000)]
        public string Language2 { get; set; }
        [MaxLength(1000)]
        public string Language3 { get; set; }
        [MaxLength(1000)]
        public string Language4 { get; set; }
        [MaxLength(1000)]
        public string Language5 { get; set; }

        public int MasterId { get; set; }
        public int ModuleId { get; set; }

        public bool IsDeleted { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
        public Guid UserCreated { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public Status Status { set; get; }
    }
}
