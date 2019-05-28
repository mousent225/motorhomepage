using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Call save change from dbcontext
        void Comit();
    }
}
