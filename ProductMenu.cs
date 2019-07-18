using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public class ProductMenu
    {
        public ProductMenu()
        {
            Basket = new Basket();
            MainMenu();
        }
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Products Menu:");
            foreach (var item in MenuItems)
                Console.WriteLine("{0}: {1} UAH", item.Name, item.Price);
            Console.WriteLine("Controls: 'B' - Basket; 'Name of product' - Add selected product to Bucket;");
            var answer = Console.ReadLine();
            var selectedItem = MenuItems.FirstOrDefault(x => x.Name == answer);
            if (answer == "B")
            {
                this.BasketMenu();
            }
            else if (selectedItem != null)
            {
                Basket.AddItem(selectedItem);
            }
        
            this.MainMenu();
        }
        public void BasketMenu()
        {
            Basket.ShowItems();
            Console.WriteLine("Controls: 1 - Main Menu; 'Name of product' - Delete selected product from bucket Menu;");
            var answer = Console.ReadLine();
            var selectedItem = MenuItems.FirstOrDefault(x => x.Name == answer);
            if (answer == "1")
            {
                this.MainMenu();
            }
            else if (selectedItem != null)
            {
                Basket.RemoveItem(selectedItem);
                BasketMenu();
            }
            else
                this.BasketMenu();
        }
        public IBasket<Product> Basket { get; set; }
        public List<Product> MenuItems { get; set; } = new List<Product>() { new Milk(), new Corn(), new Cookies(), new Pickle(), new Tomatos() };
    }
}
