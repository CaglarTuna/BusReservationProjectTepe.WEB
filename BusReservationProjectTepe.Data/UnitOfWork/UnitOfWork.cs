using BusReservationProjectTepe.Core.Repositories;
using BusReservationProjectTepe.Data.Repositories;
using BusReservationProjectTepe.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProjectTepe.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private TicketRepository _ticketRepository;
        private UserAppRepository _userRepository;

        public ITicketRepository Tickets => throw new NotImplementedException();

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
