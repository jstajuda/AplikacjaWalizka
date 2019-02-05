using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Data.Entity;


namespace MojaWalizkaDA
{
    public partial class WalizkaContext : DbContext
    {

        public WalizkaContext() : base(@"Data Source =.; Initial Catalog = WalizkaDb; Integrated Security = true; ")
        {
            Database.SetInitializer<WalizkaContext>(new CreateDatabaseIfNotExists<WalizkaContext>());
        }

        public virtual DbSet<CategoryRepository> Categories { get; set; }
        public virtual DbSet<ItemRepository> Items { get; set; }
        public virtual DbSet<ListOfItemsRepository> Lists { get; set; }
        public virtual DbSet<ParamGroupRepository> ParamGroups { get; set; }
        public virtual DbSet<ParamRepository> Params { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemRepository>()
                .HasMany(e => e.Lists)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("ItemsLists").MapLeftKey("Item").MapRightKey("List"));

            modelBuilder.Entity<ItemRepository>()
                .HasMany(e => e.Params)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("ItemsParams").MapLeftKey("Item").MapRightKey(new[] { "Parameter", "ParameterGroup" }));

            modelBuilder.Entity<ParamGroupRepository>()
                .HasMany(e => e.Params)
                .WithRequired(e => e.ParamGroup)
                .HasForeignKey(e => e.GroupID)
                .WillCascadeOnDelete(false);
        }
    }
}
