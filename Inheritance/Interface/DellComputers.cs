using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Interface
{
    class DellComputers : IComputer,IDellComputer
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public double Price { get; set; }
        
        public void GetDesktops()
        {
            Name = "Dell Pricision";
            Price = 1200;
        }

        public void GetLaptops()
        {
            Name = "Dell Voctro";
            Price = 2000;
        }

        public void GetMark()
        {
            Mark = "Dell";
        }

        public override string ToString()
        {
            return $"Name: {Name}\r\nPrice: {Price}\r\nMark: {Mark}";
        }
    }
}
