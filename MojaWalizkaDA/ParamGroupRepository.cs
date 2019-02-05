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
    [Table("ParamGroups")]
    public partial class ParamGroupRepository : IRepository<ParamGroup>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParamGroupRepository()
        {
            Params = new HashSet<ParamRepository>();
        }

        public int ParamGroupId { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParamRepository> Params { get; set; }

        public System.Collections.ObjectModel.ObservableCollection<ParamGroup> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
