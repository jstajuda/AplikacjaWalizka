using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MojaWalizkaBL
{
    [Table("ItemLists")]
    public class ItemList : INotifyPropertyChanged
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

        private DateTime? createdAt;
        public DateTime? CreatedAt
        {
            get => createdAt;
            set
            {
                createdAt = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime? updatedAt;
        public DateTime? UpdatedAt
        {
            get => updatedAt;
            set
            {
                updatedAt = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Item> items;
        public virtual ObservableCollection<Item> Items
        {
            get => items;
            set
            {
                items = value;
                NotifyPropertyChanged();
            }
        }

        private bool isPredefined;
        public bool IsPredefined
        {
            get => isPredefined;
            set
            {
                isPredefined = value;
                NotifyPropertyChanged();
            }
        }

        public ItemList()
        {

        }

        public ItemList(string name, string description, ObservableCollection<Item> items = null, bool isPredefined = false)
        {
            Id = 0;
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = null;
            Items = items;
            IsPredefined = isPredefined;
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
