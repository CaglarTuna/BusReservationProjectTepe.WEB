using BusReservationProjectTepe.Core.Models;
using BusReservationProjectTepe.Core.Repositories;
using BusReservationProjectTepe.Core.Services;
using BusReservationProjectTepe.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Service.Services
{
    public class UserService : Service<AppUser>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<AppUser> repository) : base(unitOfWork, repository)
        {

        }
    }
}
