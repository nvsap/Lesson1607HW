using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1607HW
{
    public interface IBasket<T>
    {
        void AddItem(T item);
        void RemoveItem(T item);
        void ShowItems();
        List<T> Items { get; set; }
    }
}
