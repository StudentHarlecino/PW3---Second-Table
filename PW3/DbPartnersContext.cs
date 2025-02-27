using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PW3;

public partial class DbPartnersContext : DbContext
{
    public DbPartnersContext()
    {
    }

    public DbPartnersContext(DbContextOptions<DbPartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnersPoduct> PartnersPoducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TypesOfPartner> TypesOfPartners { get; set; }

    public virtual DbSet<TypesOfProduct> TypesOfProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DB_Partners;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("partners_pkey");

            entity.ToTable("partners");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullNameOfDirector).HasColumnName("fullNameOfDirector");
            entity.Property(e => e.IdTypeOfPartner).HasColumnName("idTypeOfPartner");
            entity.Property(e => e.LegalAdress).HasColumnName("legalAdress");
            entity.Property(e => e.NameOfPartner).HasColumnName("nameOfPartner");
            entity.Property(e => e.Raiting).HasColumnName("raiting");
            entity.Property(e => e.Telephone).HasColumnName("telephone");
            entity.Property(e => e.Tin).HasColumnName("TIN");

            entity.HasOne(d => d.IdTypeOfPartnerNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdTypeOfPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partners_typesOfParner");
        });

        modelBuilder.Entity<PartnersPoduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("partners_Poducts_pkey");

            entity.ToTable("partners_poducts");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"partners_Poducts_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.DateOfSale).HasColumnName("dateOfSale");
            entity.Property(e => e.IdPartner).HasColumnName("idPartner");
            entity.Property(e => e.IdProduct).HasColumnName("idProduct");

            entity.HasOne(d => d.IdPartnerNavigation).WithMany(p => p.PartnersPoducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnersProducts_Partners");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.PartnersPoducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnersProducts_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleNumber).HasColumnName("articleNumber");
            entity.Property(e => e.IdTypeOfProduct).HasColumnName("idTypeOfProduct");
            entity.Property(e => e.MincCostForPartner)
                .HasColumnType("money")
                .HasColumnName("mincCostForPartner");
            entity.Property(e => e.NameOfProduct).HasColumnName("nameOfProduct");

            entity.HasOne(d => d.IdTypeOfProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeOfProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_products_typesOfProduct");
        });

        modelBuilder.Entity<TypesOfPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("typesOfPartner_pkey");

            entity.ToTable("typesOfPartner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeOfPartner).HasColumnName("typeOfPartner");
        });

        modelBuilder.Entity<TypesOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("typesOfProduct_pkey");

            entity.ToTable("typesOfProduct");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeOfProduct).HasColumnName("typeOfProduct");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
