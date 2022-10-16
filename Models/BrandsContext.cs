using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace XSS.Models
{
    public partial class BrandsContext : DbContext
    {
        public BrandsContext()
        {
        }

        public BrandsContext(DbContextOptions<BrandsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competition> Competition { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasColumnType("VARCHAR (5)");

                entity.Property(e => e.BrandName).HasColumnType("VARCHAR (50)");

            });

            modelBuilder.Entity<Competition>().HasData(
                new Competition
                {
                    BrandId = "1",
                    BrandName = "Nike"
                },
                new Competition
                {
                    BrandId = "2",
                    BrandName = "Adidas"
                },
                                new Competition
                                {
                                    BrandId = "3",
                                    BrandName = "Puma"
                                },
                                                new Competition
                                                {
                                                    BrandId = "4",
                                                    BrandName = "Under Armour"
                                                },
                                                                new Competition
                                                                {
                                                                    BrandId = "5",
                                                                    BrandName = "Sketchers"
                                                                }
                );

            modelBuilder.Entity<Flag>().HasData(
                new Flag {
                    FlagID = "1",
                    FlagName = "byu22ind{databa5e}"

                }



                );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
