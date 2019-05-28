using MotorHomepage.Data.Enums;
using MotorHomepage.Data.Interfaces;
using MotorHomepage.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorHomepage.Data.Entities
{
    [Table("Attachments")]
    public class Attachment : DomainEntity<int>, ISwitchable, IDateTracking, IHasSoftDelete
    {
        public int ModuleId { get; set; }
        public int MasterId { get; set; }

        [MaxLength(500)]
        [Required]
        public string FileName { get; set; }
        [MaxLength(500)]
        [Required]
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }

        public Status Status { set; get; }
        public Guid UserCreated { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public bool IsDeleted { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
    }
}
