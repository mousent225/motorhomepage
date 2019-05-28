using MotorHomepage.Data.Enums;
using MotorHomepage.Data.Interfaces;
using MotorHomepage.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorHomepage.Data.Entities
{
    [Table("SysCategories")]
    public class SysCategory : DomainEntity<int>, ISwitchable, IDateTracking, IHasSoftDelete
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Remark { get; set; }

        public bool IsDeleted { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
        public Guid UserCreated { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public Status Status { set; get; }

        public virtual ICollection<SysCategoryValue> SysCategoryValues { get; set; }
    }
}
