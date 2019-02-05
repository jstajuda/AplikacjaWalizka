using MojaWalizkaBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MojaWalizkaDA
{
    [Table("Params")]
    public partial class ParamRepository :IRepository<Param>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParamRepository()
        {
            Items = new HashSet<ItemRepository>();
        }

        [Key]
        [Column(Order = 0)]
        public int ParamId { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        public virtual ParamGroupRepository ParamGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRepository> Items { get; set; }
        
        public System.Collections.ObjectModel.ObservableCollection<Param> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
