using Microsoft.AspNetCore.Identity;
using MotorHomepage.Data.Enums;
using MotorHomepage.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorHomepage.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable, IHasSoftDelete
    {
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Avatar { get; set; }
        
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { set; get; }
        public Guid UserCreated { set; get; }
        public Guid? UserModified { set; get; }
        public Guid? UserDeleted { set; get; }
    }
}
