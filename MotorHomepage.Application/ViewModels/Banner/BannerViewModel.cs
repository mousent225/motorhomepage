using MotorHomepage.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MotorHomepage.Application.ViewModels.Banner
{
    public class BannerViewModel
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        
        public string SubHeading { get; set; }
        
        public string Description { get; set; }
        
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
