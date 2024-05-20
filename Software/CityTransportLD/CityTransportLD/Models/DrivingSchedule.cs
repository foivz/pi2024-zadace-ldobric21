using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransportLD.Models
{
    public class DrivingSchedule
    {
        public int IdDrivingLine { get; set; }
        public int IdStation { get; set; }
        public float Price { get; set; }
        public DateTime TimeOfDeparture { get; set; }
    }
}
