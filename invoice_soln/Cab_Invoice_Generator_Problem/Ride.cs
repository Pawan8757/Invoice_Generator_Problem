using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator_Problem
{
    public class Ride
    {
        public double distance;
        public int time;
        public Ride(float distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}