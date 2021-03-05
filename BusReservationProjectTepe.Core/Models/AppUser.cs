using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Core.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName{ get; set; }
        public string Surname{ get; set; }
        public string AppUserRoleId { get; set; }
        public virtual AppUserRoles AppUserRoles { get; set; }
    }
}
