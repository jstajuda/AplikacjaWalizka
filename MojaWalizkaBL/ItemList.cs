using System;
using System.Collections.Generic;
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
        public List<Item> Items { get; set; }

        public ItemList(int itemListId, string name, string description, List<Item> items = null)
        {
            ItemListId = itemListId;
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
