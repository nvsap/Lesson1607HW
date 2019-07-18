using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.ProductMenu = new ProductMenu();
        }
        public ProductMenu ProductMenu { get; set; }
    }
}
