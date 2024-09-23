using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EsayAccount.DAL2
{
    public partial class EasyAccount22Context : DbContext
    {
        public EasyAccount22Context()
        {
        }

        public EasyAccount22Context(DbContextOptions<EasyAccount22Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CustmerSuplier> CustmerSuplier { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetalies> InvoiceDetalies { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<UnitName> UnitName { get; set; }
        public virtual DbSet<UnitProduct> UnitProduct { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Sett.cn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.CodeBranch);

                entity.Property(e => e.CodeBranch).ValueGeneratedNever();

                entity.Property(e => e.IdBranch).ValueGeneratedOnAdd();

                entity.Property(e => e.NameAr).HasMaxLength(50);

                entity.Property(e => e.NameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CodeCategory);

                entity.Property(e => e.CodeCategory).ValueGeneratedNever();

                entity.Property(e => e.IdCategory).ValueGeneratedOnAdd();

                entity.Property(e => e.NameCategory).HasMaxLength(50);
            });

            modelBuilder.Entity<CustmerSuplier>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Tel1).HasMaxLength(50);

                entity.Property(e => e.Tel2).HasMaxLength(50);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderDateAdd).HasColumnType("date");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.BranchCode)
                    .HasConstraintName("FK_Invoice_Branch1");

                entity.HasOne(d => d.CustmerSuplierCodeNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CustmerSuplierCode)
                    .HasConstraintName("FK_Invoice_CustmerSuplier");

                entity.HasOne(d => d.UserCodeNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.UserCode)
                    .HasConstraintName("FK_Invoice_Users");
            });

            modelBuilder.Entity<InvoiceDetalies>(entity =>
            {
                entity.HasOne(d => d.InvoiceCodeNavigation)
                    .WithMany(p => p.InvoiceDetalies)
                    .HasForeignKey(d => d.InvoiceCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InvoiceDetalies_Invoice");

                entity.HasOne(d => d.StoreCodeNavigation)
                    .WithMany(p => p.InvoiceDetalies)
                    .HasForeignKey(d => d.StoreCode)
                    .HasConstraintName("FK_InvoiceDetalies_Store1");

                entity.HasOne(d => d.UintProductCodeNavigation)
                    .WithMany(p => p.InvoiceDetalies)
                    .HasForeignKey(d => d.UintProductCode)
                    .HasConstraintName("FK_InvoiceDetalies_UnitProduct");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.CodeProduct);

                entity.Property(e => e.CodeProduct).ValueGeneratedNever();

                entity.Property(e => e.IdProduct).ValueGeneratedOnAdd();

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasColumnType("image");

                entity.Property(e => e.NameProduct).HasMaxLength(50);

                entity.HasOne(d => d.CodeBranchNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CodeBranch)
                    .HasConstraintName("FK_Product_Branch");

                entity.HasOne(d => d.CodeCategoryNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CodeCategory)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.CodeStoreNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CodeStore)
                    .HasConstraintName("FK_Product_Store");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.CodeStore);

                entity.Property(e => e.CodeStore).ValueGeneratedNever();

                entity.Property(e => e.IdStore).ValueGeneratedOnAdd();

                entity.Property(e => e.NameStore).HasMaxLength(50);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.BranchCode)
                    .HasConstraintName("FK_Store_Branch1");
            });

            modelBuilder.Entity<UnitName>(entity =>
            {
                entity.HasKey(e => e.CodeUnit);

                entity.Property(e => e.CodeUnit).ValueGeneratedNever();

                entity.Property(e => e.IdUnit).ValueGeneratedOnAdd();

                entity.Property(e => e.NameUnit).HasMaxLength(50);
            });

            modelBuilder.Entity<UnitProduct>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.UnitProduct)
                    .HasForeignKey(d => d.ProductCode)
                    .HasConstraintName("FK_UnitProduct_Product");

                entity.HasOne(d => d.UintNameCodeNavigation)
                    .WithMany(p => p.UnitProduct)
                    .HasForeignKey(d => d.UintNameCode)
                    .HasConstraintName("FK_UnitProduct_UnitName");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BranchCode)
                    .HasConstraintName("FK_Users_Branch");
            });
        }
    }
}
