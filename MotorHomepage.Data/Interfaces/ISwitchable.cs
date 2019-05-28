using MotorHomepage.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
