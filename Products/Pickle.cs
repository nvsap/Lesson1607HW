using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Pickle : Product
    {
        public Pickle()
        {
            this.Name = "Pickle";
            this.Price = 30;
        }
        public override string Name { get; set; }
        public override int Price { get; set; }
    }
}
