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
    /// Klasa reprezentuje kategorię służącą do klasyfikowania przedmiotów.
    /// </summary>
    [Table("Categories")]
    public class Category : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

       
        private string name;
        /// <summary>
        /// Nazwa kategorii.
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
        /// Krótki opis kategorii.
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

        /// <summary>
        /// Kolekcja powiązanych z kategorią przedmiotów.
        /// </summary>
        public virtual ICollection<Item> Items { get; set; }

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
