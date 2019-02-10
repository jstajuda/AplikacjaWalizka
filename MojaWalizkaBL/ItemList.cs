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
    /// <summary>
    /// Klasa reprezentuje listę przedmiotów.
    /// </summary>
    [Table("ItemLists")]
    public class ItemList : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        private string name;
        /// <summary>
        /// Nazwa listy przedmiotów.
        /// </summary>
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
        /// <summary>
        /// Krótki opis listy przedmiotów.
        /// </summary>
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
        /// <summary>
        /// Data utworzenia listy przedmiotów.
        /// </summary>
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
        /// <summary>
        /// Data modyfikacji listy przedmiotów.
        /// </summary>
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
        /// <summary>
        /// Kolekcja przedmiotów przypisanych do listy.
        /// </summary>
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
        /// <summary>
        /// Czy lista jest listą predefiniowaną (tak / nie).
        /// </summary>
        public bool IsPredefined
        {
            get => isPredefined;
            set
            {
                isPredefined = value;
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
