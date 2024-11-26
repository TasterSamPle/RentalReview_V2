using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalReview_V2
{
    public class Van : Vehicle
    {
        public double Height { get; set; }

        
        public Van(int wheels, double weight, string registration, double height)
            : base(wheels, weight, registration)  
        {
            Height = height;
        }
    }
}

