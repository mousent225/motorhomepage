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
    [Table("BannerVis")]
    public class BannerVi : DomainEntity<int>
    {
        [MaxLength(255)]
        public string Heading { get; set; }
        [MaxLength(255)]
        public string SubHeading { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public int MasterId { get; set; }
        [ForeignKey("MasterId")]
        public virtual Banner Banner { get; set; }
    }
}
