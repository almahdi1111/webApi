﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BillDetailes> BillDetailes { get; set; }
        public virtual DbSet<BillsMaster> BillsMaster { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Coin> Coin { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerCredits> CustomerCredits { get; set; }
        public virtual DbSet<OrderDetailes> OrderDetailes { get; set; }
        public virtual DbSet<OrderMaster> OrderMaster { get; set; }
        public virtual DbSet<Privileges> Privileges { get; set; }
        public virtual DbSet<RawMaterial> RawMaterial { get; set; }
        public virtual DbSet<StoreCategoryCredits> StoreCategoryCredits { get; set; }
        public virtual DbSet<StoreRawCredits> StoreRawCredits { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<UserPrivileges> UserPrivileges { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDetailes>(entity =>
            {
                entity.ToTable("BILL_Detailes");

                entity.Property(e => e.BillDetailesId)
                    .ValueGeneratedNever()
                    .HasColumnName("Bill_Detailes_ID");

                entity.Property(e => e.BillMasterId).HasColumnName("Bill_Master_ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.QuantityPrice).HasColumnName("Quantity_Price");

                entity.HasOne(d => d.BillMaster)
                    .WithMany(p => p.BillDetailes)
                    .HasForeignKey(d => d.BillMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BILL_Deta__Bill___414EAC47");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BillDetailes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BILL_Deta__Categ__4242D080");
            });

            modelBuilder.Entity<BillsMaster>(entity =>
            {
                entity.HasKey(e => e.BillMasterId)
                    .HasName("Bill_Master_PK");

                entity.ToTable("BILLS_Master");

                entity.Property(e => e.BillMasterId)
                    .ValueGeneratedNever()
                    .HasColumnName("Bill_Master_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BillsMaster)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BILLS_Mas__Custo__2C538F61");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.BillsMaster)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BILLS_Mas__ID_Us__2B5F6B28");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("Category_PK");

                entity.ToTable("CATEGORIES");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Category_ID");

                entity.Property(e => e.IdCoin).HasColumnName("ID_Coin");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.NameCategory)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_Category");

                entity.Property(e => e.PriceCategory).HasColumnName("Price_Category");

                entity.HasOne(d => d.IdCoinNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.IdCoin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CATEGORIE__ID_Co__4707859D");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CATEGORIE__ID_Us__2F2FFC0C");
            });

            modelBuilder.Entity<Coin>(entity =>
            {
                entity.ToTable("COIN");

                entity.Property(e => e.CoinId)
                    .ValueGeneratedNever()
                    .HasColumnName("Coin_ID");

                entity.Property(e => e.NameCoin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_coin");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Coin)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COIN__User_id__1B29035F");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.CustmerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Custmer_name");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Address");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CUSTOMER__User_I__1E05700A");
            });

            modelBuilder.Entity<CustomerCredits>(entity =>
            {
                entity.HasKey(e => e.CustomerCredeitId)
                    .HasName("Customer_Credeit_PK");

                entity.ToTable("CUSTOMER_CREDITS");

                entity.Property(e => e.CustomerCredeitId)
                    .ValueGeneratedNever()
                    .HasColumnName("Customer_Credeit_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.IdCoin).HasColumnName("ID_Coin");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCredits)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMER___Custo__25A691D2");

                entity.HasOne(d => d.IdCoinNavigation)
                    .WithMany(p => p.CustomerCredits)
                    .HasForeignKey(d => d.IdCoin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMER___ID_Co__24B26D99");
            });

            modelBuilder.Entity<OrderDetailes>(entity =>
            {
                entity.ToTable("ORDER_Detailes");

                entity.Property(e => e.OrderDetailesId)
                    .ValueGeneratedNever()
                    .HasColumnName("ORDER_Detailes_ID");

                entity.Property(e => e.OrderMasterId).HasColumnName("ORDER_Master_ID");

                entity.Property(e => e.QuantityPrice).HasColumnName("Quantity_Price");

                entity.Property(e => e.RawMaterialId).HasColumnName("Raw_Material_ID");

                entity.HasOne(d => d.OrderMaster)
                    .WithMany(p => p.OrderDetailes)
                    .HasForeignKey(d => d.OrderMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER_Det__ORDER__451F3D2B");

                entity.HasOne(d => d.RawMaterial)
                    .WithMany(p => p.OrderDetailes)
                    .HasForeignKey(d => d.RawMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER_Det__Raw_M__46136164");
            });

            modelBuilder.Entity<OrderMaster>(entity =>
            {
                entity.ToTable("ORDER_Master");

                entity.Property(e => e.OrderMasterId)
                    .ValueGeneratedNever()
                    .HasColumnName("Order_Master_ID");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("Order_Date");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.OrderMaster)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER_Mas__ID_Us__3E723F9C");
            });

            modelBuilder.Entity<Privileges>(entity =>
            {
                entity.HasKey(e => e.PrivilegeId)
                    .HasName("Privilege_PK");

                entity.ToTable("PRIVILEGES");

                entity.Property(e => e.PrivilegeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Privilege_ID");

                entity.Property(e => e.PrivilegeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Privilege_name");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_ID_FK");
            });

            modelBuilder.Entity<RawMaterial>(entity =>
            {
                entity.ToTable("RAW_MATERIAL");

                entity.Property(e => e.RawMaterialId)
                    .ValueGeneratedNever()
                    .HasColumnName("Raw_Material_ID");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.NameRawMaterial)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_Raw_Material");

                entity.Property(e => e.PriceRawMaterial).HasColumnName("Price_Raw_Material");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.RawMaterial)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RAW_MATER__ID_Us__320C68B7");
            });

            modelBuilder.Entity<StoreCategoryCredits>(entity =>
            {
                entity.HasKey(e => e.StoreCredeitId)
                    .HasName("Store_Credeit_PK");

                entity.ToTable("STORE_Category_CREDITS");

                entity.Property(e => e.StoreCredeitId)
                    .ValueGeneratedNever()
                    .HasColumnName("Store_Credeit_ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.StoreQuantity).HasColumnName("Store_Quantity");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.StoreCategoryCredits)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORE_Cat__Categ__36D11DD4");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StoreCategoryCredits)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORE_Cat__ID_Us__34E8D562");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreCategoryCredits)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORE_Cat__Store__35DCF99B");
            });

            modelBuilder.Entity<StoreRawCredits>(entity =>
            {
                entity.HasKey(e => e.StoreRawCredeitId)
                    .HasName("Store_RAW_Credeit_PK");

                entity.ToTable("STORE_RAW_CREDITS");

                entity.Property(e => e.StoreRawCredeitId)
                    .ValueGeneratedNever()
                    .HasColumnName("Store_RAW_Credeit_ID");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.RawMaterialId).HasColumnName("Raw_Material_ID");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.StoreQuantity).HasColumnName("Store_Quantity");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StoreRawCredits)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORE_RAW__ID_Us__39AD8A7F");

                entity.HasOne(d => d.RawMaterial)
                    .WithMany(p => p.StoreRawCredits)
                    .HasForeignKey(d => d.RawMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORE_RAW__Raw_M__3B95D2F1");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreRawCredits)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORE_RAW__Store__3AA1AEB8");
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("Store_PK");

                entity.ToTable("STORES");

                entity.Property(e => e.StoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("Store_ID");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.StoreLocacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Store_Locacion");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STORES__ID_User__2882FE7D");
            });

            modelBuilder.Entity<UserPrivileges>(entity =>
            {
                entity.HasKey(e => e.IdUserPrivilege)
                    .HasName("User_Privilege_PK");

                entity.ToTable("USER_PRIVILEGES");

                entity.Property(e => e.IdUserPrivilege)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_User_Privilege");

                entity.Property(e => e.PrivilegeId).HasColumnName("Privilege_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.UserPrivileges)
                    .HasForeignKey(d => d.PrivilegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_PRIV__Privi__20E1DCB5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPrivileges)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_PRIV__User___21D600EE");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("User_PK");

                entity.ToTable("USERS");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("User_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}