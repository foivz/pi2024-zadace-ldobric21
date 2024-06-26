﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransportLD.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public int Capacity { get; set; }
        public DateTime DateOfService { get; set; }
        public int IdEmployee { get; set; }

        public override string ToString()
        {
            return Id + " " + Registration;
        }
    }
}
