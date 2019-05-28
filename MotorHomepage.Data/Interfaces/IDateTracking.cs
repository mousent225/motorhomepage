using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.Interfaces
{
    public interface IDateTracking
    {        
        Guid UserCreated { get; set; }
        DateTime DateCreated { get; set; }
        Guid? UserModified { get; set; }
        DateTime? DateModified { get; set; }
    }
}
