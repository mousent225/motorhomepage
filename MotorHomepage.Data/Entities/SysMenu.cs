using MotorHomepage.Data.Enums;
using MotorHomepage.Data.Interfaces;
using MotorHomepage.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorHomepage.Data.Entities
{
    [Table("SysMenus")]
    public class SysMenu : DomainEntity<string>, ISwitchable, ISortable, IHasSoftDelete, IDateTracking
    {
        public SysMenu()
        {
        }

        public SysMenu(string name, string uRL, string parentId, string iconCss, bool isDeleted, int sortOrder, Status status, 
            DateTime dateDeleted, DateTime dateCreated, DateTime dateModified, Guid userCreated, Guid userModified, Guid userDeleted)
        {
            Name = name;
            URL = uRL;
            ParentId = parentId;
            IconCss = iconCss;
            IsDeleted = isDeleted;
            SortOrder = sortOrder;
            Status = status;
            DateDeleted = dateDeleted;
            DateCreated = dateCreated;
            DateModified = dateModified;
            UserCreated = userCreated;
            UserModified = userModified;
            UserDeleted = userDeleted;
        }

        [Required]
        [StringLength(128)]
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string URL { set; get; }

        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public Guid UserCreated { set; get; }
        public DateTime? DateDeleted { set; get; }
        public Guid? UserDeleted { set; get; }
        public Guid? UserModified { set; get; }
        public DateTime? DateModified { set; get; }
        public bool IsDeleted { set; get; }
    }
}
