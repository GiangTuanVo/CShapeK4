using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Abtract
{
    class Bus : Vehicle
    {
        public override double GetFuelAmount()
        {
            return 300;
        }
    }
}
