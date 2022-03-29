using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi1
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("DriverName : {0}", DriverName);
                Console.WriteLine("OnDuty : Yes");
                Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            }
            else
            {
                Console.WriteLine("DriverName : {0}", DriverName);
                Console.WriteLine("OnDuty : No");
                Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            }
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("\n{0} sedang mengantar pwnumpang", DriverName);
        }
    }
}
