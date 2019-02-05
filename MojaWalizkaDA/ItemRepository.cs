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
    [Table("Items")]
    public partial class ItemRepository :IRepository<Item>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemRepository()
        {
            Lists = new HashSet<ListRepository>();
            Params = new HashSet<ParamRepository>();
        }

        public int ItemId { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListRepository> Lists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParamRepository> Params { get; set; }

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
