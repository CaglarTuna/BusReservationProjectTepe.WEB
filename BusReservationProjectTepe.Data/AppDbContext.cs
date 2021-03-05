using BusReservationProjectTepe.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<AppUser> AppUsers{ get; set; }
        public DbSet<AppUserRoles> AppUserRoles{ get; set; }
        public DbSet<Tickets> Tickets{ get; set; }
        public DbSet<Seats> Seats{ get; set; }
        public DbSet<Destinations> Destinations{ get; set; }
        public DbSet<Buses> Buses{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<AppUser>().HasOne(x => x.AppUserRoles).WithMany(x=>x.AppUsers).HasForeignKey(x=>x.AppUserRoleId);
        }
    }
}
