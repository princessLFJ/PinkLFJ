namespace Dining.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiningDbContext : DbContext
    {
        public DiningDbContext()
            : base("name=DiningDbContext")
        {
        }

        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<Manage> Manage { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<menu2> menu2 { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
