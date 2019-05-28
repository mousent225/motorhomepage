using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
        DateTime?DateDeleted { get; set; }
        Guid? UserDeleted { get; set; }
    }
}
