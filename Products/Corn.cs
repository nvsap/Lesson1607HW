using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Corn : Product
    {
        public Corn()
        {
            this.Name = "Corn";
            this.Price = 11;
        }
        public override string Name { get; set; }
        public override int Price { get; set; }
    }
}
