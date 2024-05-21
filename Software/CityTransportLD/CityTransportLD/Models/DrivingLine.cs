using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransportLD.Models
{
    public class DrivingLine
    {
        public int Id { get; set; }
        public int IdVehicle { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}
