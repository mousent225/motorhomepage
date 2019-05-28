using MotorHomepage.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorHomepage.Data.Entities
{
    [Table("PostVis")]
    public class PostVi : DomainEntity<int>
    {
        public int MasterId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public string Content { get; set; }
        [MaxLength(250)]
        public string ImageCaption { get; set; }

        [ForeignKey("MasterId")]
        public virtual Post Post { get; set; }
    }
}
