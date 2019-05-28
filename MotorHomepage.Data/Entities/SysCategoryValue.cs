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
    [Table("SysCategoryValues")]
    public class SysCategoryValue : DomainEntity<int>, ISwitchable, IDateTracking, IHasSoftDelete, ISortable
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        public int? DictionaryId { get; set; }
        public int? CategoryId { get; set; }
        public int? ParentId { get; set; }
        
        public bool IsDeleted { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
        public Guid UserCreated { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public Status Status { set; get; }
        public int SortOrder { set; get; }

        [ForeignKey("CategoryId")]
        public virtual SysCategory SysCategory { get; set; }
        [ForeignKey("DictionaryId")]
        public virtual SysDictionary SysDictionary { get; set; }
    }
}
