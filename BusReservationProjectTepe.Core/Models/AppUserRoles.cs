using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Core.Models
{
    public class AppUserRoles : IdentityRole
    {
        public ICollection<AppUser> AppUsers { get; set; }
    }
}
