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
    [Table("Posts")]
    public class Post : DomainEntity<int>, ISwitchable, IDateTracking, IHasSoftDelete
    {
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }        
        public string Content { get; set; }
        [MaxLength(255)]
        public string Thumbnail { get; set; }
        [MaxLength(255)]
        public string Image { get; set; }
        [MaxLength(250)]
        public string ImageCaption { get; set; }
        public DateTime PublishedDate { get; set; }
        public int CategoryId { get; set; }

        public bool IsDeleted { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
        public Guid UserCreated { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public Status Status { set; get; }
        public PublishStatus PublishStatus { get; set; }

        [ForeignKey("CategoryId")]
        public virtual SysCategory SysCategory { get; set; }
    }
}
