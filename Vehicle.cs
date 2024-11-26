using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalReview_V2
{
    public class Vehicle
    {
        public int Wheels { get; set; }
        public double Weight { get; set; }
        public string Registration { get; set; }

        public Vehicle(int wheels, double weight, string registration)
        {
            Wheels = wheels;
            Weight = weight;
            Registration = registration;
        }
    }
}
