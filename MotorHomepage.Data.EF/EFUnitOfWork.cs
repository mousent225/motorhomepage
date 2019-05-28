using MotorHomepage.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Comit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
