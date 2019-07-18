using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class Basket : IBasket<Product>
    {
        public Basket()
        {
            Items = new List<Product>();
        }
        public List<Product> Items { get; set; }

        public void AddItem(Product item)
        {
            if (Items == null || Items.Count() < 5)
                Items.Add(item);
            else
                Console.WriteLine("Your basket is already full.");
        }

        public void RemoveItem(Product item)
        {
            Items.Remove(item);
        }
        public void ShowItems()
        {
            Console.Clear();
            Console.WriteLine("Basket:");
            foreach (var item in Items)
                Console.WriteLine("{0}: {1} UAH", item.Name, item.Price);
        }
    }
}
