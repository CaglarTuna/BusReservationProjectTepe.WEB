using BusReservationProjectTepe.Core.Models;
using BusReservationProjectTepe.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Data.Repositories
{
    public class UserAppRepository : Repository<AppUser>,IUserRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public UserAppRepository(AppDbContext context) : base(context)
        {
        }
    }
}
