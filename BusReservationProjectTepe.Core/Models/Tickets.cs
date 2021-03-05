﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusReservationProjectTepe.Core.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public virtual AppUser Users { get; set; }
        public virtual Seats Seats { get; set; }
        public virtual Buses Buses { get; set; }
    }
}
