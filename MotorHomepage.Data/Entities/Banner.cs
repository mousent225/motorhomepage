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
    [Table("Banners")]
    public class Banner : DomainEntity<int>, ISwitchable, IDateTracking, IHasSoftDelete
    {
        [MaxLength(255)]
        public string Heading { get; set; }
        [MaxLength(255)]
        public string SubHeading { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        [MaxLength(250)]
        public string Image { get; set; }

        public Guid UserCreated { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public Status Status { set; get; }
        public PublishStatus PublishStatus { get; set; }
        public bool IsDeleted { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
    }
}
