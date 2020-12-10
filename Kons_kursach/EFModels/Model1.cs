namespace Kons_kursach.EFModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<contract> contract { get; set; }
        public virtual DbSet<obje> obje { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<worker> worker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.type_of_face)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<contract>()
                .Property(e => e.contract_name)
                .IsUnicode(false);

            modelBuilder.Entity<contract>()
                .Property(e => e.contract_type)
                .IsUnicode(false);

            modelBuilder.Entity<contract>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<contract>()
                .HasMany(e => e.obje)
                .WithOptional(e => e.contract)
                .HasForeignKey(e => e.contractFK);

            modelBuilder.Entity<obje>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<obje>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<obje>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<obje>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<worker>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<worker>()
                .Property(e => e.post)
                .IsUnicode(false);
        }
    }
}
