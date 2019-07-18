using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Tomatos : Product
    {
        public Tomatos()
        {
            this.Name = "Tomatos";
            this.Price = 23;
        }
        public override string Name { get; set; }
        public override int Price { get; set; }
    }
}
