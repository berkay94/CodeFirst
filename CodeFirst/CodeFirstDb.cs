using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class CodeFirstDb:DbContext
    {
        public DbSet<Kisiler> Kisiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisiler>().ToTable("Kisiler");
            modelBuilder.Entity<Kisiler>().Property(p => p.Ad)
                .HasColumnName("Adi")
                .HasColumnOrder(2)
                .HasMaxLength(30)
                .IsRequired();


            modelBuilder.Entity<Firma>().ToTable("Firmalar");
            modelBuilder.Entity<Marka>().ToTable("Marka");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
        }
    }
}
