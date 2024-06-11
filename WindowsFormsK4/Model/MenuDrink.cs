using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsK4.Model
{
    class MenuDrink
    {
        public MenuDrink(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Price}";
        }
    }
}
