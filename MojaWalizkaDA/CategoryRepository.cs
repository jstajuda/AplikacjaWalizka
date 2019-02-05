using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using MojaWalizkaBL;

namespace MojaWalizkaDA
{
    [Table("Categories")]
    public partial class CategoryRepository : IRepository<Category>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoryRepository()
        {
            Items = new HashSet<ItemRepository>();
        }

        [Key]
        public int CategoryId { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRepository> Items { get; set; }

        public System.Collections.ObjectModel.ObservableCollection<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
