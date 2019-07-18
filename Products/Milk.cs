using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Milk : Product
    {
        public Milk()
        {
            this.Name = "Milk";
            this.Price = 27;
        }
        public override string Name { get; set; }
        public override int Price { get; set; }
    }
}
