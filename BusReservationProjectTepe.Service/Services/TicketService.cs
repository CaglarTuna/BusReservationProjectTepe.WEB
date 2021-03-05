using BusReservationProjectTepe.Core.Models;
using BusReservationProjectTepe.Core.Repositories;
using BusReservationProjectTepe.Core.Services;
using BusReservationProjectTepe.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Service.Services
{
    public class TicketService : Service<Tickets>, ITicketService
    {
        public TicketService(IUnitOfWork unitOfWork, IRepository<Tickets> repository) : base(unitOfWork, repository)
        {

        }

    }
}
