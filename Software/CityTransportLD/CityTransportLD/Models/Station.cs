using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransportLD.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Adress + " " + Description;
        }
    }
}
