using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaBL
{
    public class ItemList
    {
        public int ItemListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ObservableCollection<Item> Items { get; set; }

        public ItemList(int itemListId, string name, string description, ObservableCollection<Item> items = null)
        {
            ItemListId = itemListId;
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Items = items;
        }
    }
}
