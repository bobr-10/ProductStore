using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFexample.Classes
{
    public class Food
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
