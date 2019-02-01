using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaBL
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public Item(int itemId, string name, string description, string category)
        {
            ItemId = itemId;
            Name = name;
            Description = description;
            Category = category;
        }
    }
}
