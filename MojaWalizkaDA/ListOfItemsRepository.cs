using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MojaWalizkaDA
{
    [Table("Lists")]
    public partial class ListOfItemsRepository : IRepository<ListOfItems>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListOfItemsRepository()
        {
            Items = new HashSet<ItemRepository>();
        }

        [Key]
        public int ListId { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRepository> Items { get; set; }
        
        ObservableCollection<ListOfItems> itemLists;

        public ObservableCollection<ListOfItems> GetAll()
        {
            return GetTestItemLists();
        }

        public ObservableCollection<ListOfItems> GetLatest()
        {
            itemLists = GetTestItemLists();
            itemLists.Remove(itemLists[0]);
            itemLists.Remove(itemLists[0]);
            return itemLists;
        }

        private ObservableCollection<ListOfItems> GetTestItemLists()
        {
            return new ObservableCollection<ListOfItems>()
            {
                new ListOfItems(1, "Madagaskar", "ten niebieski", new ObservableCollection<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ListOfItems(2, "Nowa Zelandia", "brązowe skórzane", new ObservableCollection<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ListOfItems(3, "Bździochy Wielkie", "Wczasy pod strzechą u gaździny", new ObservableCollection<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ListOfItems(4, "Sopot", "Opierdoling na molo", new ObservableCollection<Item>(){
                    new Item(1, "Ręcznik", "ten niebieski", "Higiena"),
                    new Item(2, "Półbuty", "brązowe skórzane", "Obuwie"),
                    new Item(3, "Sweter", "Różowy w grochy", "Ubranie"),
                    new Item(4, "Żel pod prysznic", "super energy for menly men", "Higiena"),
                    new Item(5, "Powerbank", "ten 30000mAh z latarką", "Elektronika")
                }),

                new ListOfItems(5, "Juesej", "Niagara i wielki kanion - jak wszyscy", new ObservableCollection<Item>(){
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
