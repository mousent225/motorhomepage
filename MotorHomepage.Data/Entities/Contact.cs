using MotorHomepage.Data.Interfaces;
using MotorHomepage.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorHomepage.Data.Entities
{
    [Table("Contacts")]
    public class Contact : DomainEntity<int>
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(5000)]
        public string Message { get; set; }
        public string Company { get; set; }
        public int CountryId { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
