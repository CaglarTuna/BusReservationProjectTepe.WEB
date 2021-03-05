using AutoMapper;
using BusReservationProjectTepe.Core.Models;
using BusReservationProjectTepe.WEB.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationProjectTepe.WEB.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AppUser, UserDto>();
            CreateMap<UserDto,AppUser>();
        }
    }
}
