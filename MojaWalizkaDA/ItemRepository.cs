using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    public class ItemRepository :IRepository<Item>
    {
        ObservableCollection<Item> items;

        public ObservableCollection<Item> GetAll()
        {
            return GetTestItems();
        }

        private ObservableCollection<Item> GetTestItems()
        {
            return new ObservableCollection<Item>()
            {
                new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
            };
        }
    }
}
