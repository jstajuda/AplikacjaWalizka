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
    /// <summary>
    /// Klasa reprezentuje przedmioty możliwe do umieszczenia na listach.
    /// </summary>
    [Table("Items")]
    public class Item : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        private string name;
        /// <summary>
        /// Nazwa przedmiotu.
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
        /// Krótki opis przedmiotu.
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


        private int categoryId;
        /// <summary>
        /// Id kategorii, do której przypisany jest przedmiot.
        /// </summary>
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
        /// <summary>
        /// Obiekt kategorii, do której przypisany jest przedmiot.
        /// </summary>
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
        /// <summary>
        /// Kolekcja list, do których przypisany jest przedmiot.
        /// </summary>
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
