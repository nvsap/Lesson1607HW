using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Cookies : Product
    {
        public Cookies()
        {
            this.Name = "Cookies";
            this.Price = 999;
        }
        public override string Name { get; set; }
        public override int Price { get; set; }
    }
}
