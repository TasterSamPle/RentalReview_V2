using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalReview_V2
{
    public class Car : Vehicle
    {
        public int NumberOfPassengers { get; set; }

        
        public Car(int wheels, double weight, string registration, int numberOfPassengers)
            : base(wheels, weight, registration)  
        {
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
