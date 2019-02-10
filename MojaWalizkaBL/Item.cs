using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaBL
{
    [Table("Items")]
    public class Item : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        private string name;
        [Required]
        [StringLength(100)]
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }

        private string description;
        [StringLength(200)]
        public string Description
        {
            get => description;
            set
            {
                description = value;
                NotifyPropertyChanged();
            }
        }

        private int categoryId;
        public int CategoryId
        {
            get => categoryId;
            set
            {
                categoryId = value;
                NotifyPropertyChanged();
            }
        }

        private Category category;
        public virtual Category Category
        {
            get => category;
            set
            {
                category = value;
                NotifyPropertyChanged();
            }
        }

        private ICollection<ItemList> itemLists;
        public virtual ICollection<ItemList> ItemLists
        {
            get => itemLists;
            set
            {
                itemLists = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
