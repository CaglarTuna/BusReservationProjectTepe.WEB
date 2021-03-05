using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BusReservationProjectTepe.Core.Models
{
    public class Destinations
    {
        public Destinations()
        {
            Buses = new Collection<Buses>();
        }
        public int Id { get; set; }
        public string Destination { get; set; }
        public ICollection<Buses> Buses { get; set; }
    }
}
