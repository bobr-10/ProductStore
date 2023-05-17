using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFexample.Classes
{
    public class Order : Food
    {
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
