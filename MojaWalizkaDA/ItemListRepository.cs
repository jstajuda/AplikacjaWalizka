using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaDA
{
    public class ItemListRepository : IRepository<ItemList>
    {
        ObservableCollection<ItemList> itemLists;

        public ObservableCollection<ItemList> GetAll()
        {
            return GetTestItemLists();
        }

        public ObservableCollection<ItemList> GetLatest()
        {
            itemLists = GetTestItemLists();
            itemLists.Remove(itemLists[0]);
            itemLists.Remove(itemLists[0]);
            return itemLists;
        }

        private ObservableCollection<ItemList> GetTestItemLists()
        {
            return new ObservableCollection<ItemList>()
            {
                new ItemList(1, "Madagaskar", "ten niebieski", new List<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ItemList(2, "Nowa Zelandia", "brązowe skórzane", new List<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ItemList(3, "Bździochy Wielkie", "Wczasy pod strzechą u gaździny", new List<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ItemList(4, "Sopot", "Opierdoling na molo", new List<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ItemList(5, "Juesej", "Niagara i wielki kanion - jak wszyscy", new List<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                })
            };
        }
    }

}
