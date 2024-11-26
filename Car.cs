using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalReview_V2
{
    public class CarForm : Vehicle
    {
        public int NumberOfPassengers { get; set; }

        
        public CarForm(int wheels, double weight, string registration, int numberOfPassengers)
            : base(wheels, weight, registration)  
        {
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
