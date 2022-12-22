using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    public class Cars
    {

        public double tank_size { get; }  

        public double fuel_per_mile { get; }

        public Cars(double fuel_per_mile, double tank_size) {
            this.fuel_per_mile = fuel_per_mile;
            this.tank_size = tank_size;


        }

        public void calculateFuelCost(double fuel_per_mile, double tank_size) { 
            if (fuel_per_mile > tank_size)
            {
                Console.WriteLine("Fuel per mile  can not be greater than the tanks size");
            }
            else
            {

                Console.WriteLine($"Your car will need to refuel every after {tank_size / fuel_per_mile}");
            }
        }

    }
}
