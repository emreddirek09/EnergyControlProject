﻿// <auto-generated />
using System;
using EnergyControlProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240128213344_mig17")]
    partial class mig17
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.Akaryakit", b =>
                {
                    b.Property<int>("AkaryakitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AkaryakitID"));

                    b.Property<decimal>("AkaryakitAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AkaryakitCarPlaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AkaryakitCustomerCarsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("AkaryakitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AkaryakitID");

                    b.HasIndex("AkaryakitCustomerCarsID");

                    b.ToTable("Akaryakits");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CarTypes", b =>
                {
                    b.Property<int>("CarTypesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarTypesID"));

                    b.Property<string>("CarTypesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarTypesID");

                    b.ToTable("CarTypeses");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerAccount", b =>
                {
                    b.Property<int>("CustomerAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerAccountID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountBalance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountBankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerAccountID");

                    b.HasIndex("AppUserID");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerAccountProcess", b =>
                {
                    b.Property<int>("CustomerAccountProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerAccountProcessID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CustomerAccountProcessType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProcessDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerAccountProcessID");

                    b.ToTable("CustomerAccountProcesses");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerCar", b =>
                {
                    b.Property<int>("CustomerCarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerCarID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("CarTypesID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CustomerCarDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerCarEnergyType")
                        .HasColumnType("int");

                    b.Property<string>("CustomerCarPlaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerCarType")
                        .HasColumnType("int");

                    b.Property<int>("EnergyTypesID")
                        .HasColumnType("int");

                    b.HasKey("CustomerCarID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("CarTypesID");

                    b.HasIndex("EnergyTypesID");

                    b.ToTable("CustomerCars");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerWallet", b =>
                {
                    b.Property<int>("CustomerWalletID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerWalletID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerWalletAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerWalletName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerWalletID");

                    b.HasIndex("AppUserID");

                    b.ToTable("CustomerWallet");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.EnergyTypes", b =>
                {
                    b.Property<int>("EnergyTypesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnergyTypesID"));

                    b.Property<string>("EnergyTypesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnergyTypesID");

                    b.ToTable("EnergyTypeses");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.WalletTypes", b =>
                {
                    b.Property<int>("WalletTypesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalletTypesID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerWalletID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WalletName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WalletTypesID");

                    b.HasIndex("CustomerWalletID");

                    b.ToTable("WalletTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.Akaryakit", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.CustomerCar", "AkaryakitCustomerCars")
                        .WithMany()
                        .HasForeignKey("AkaryakitCustomerCarsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AkaryakitCustomerCars");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerAccount", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", "AppUser")
                        .WithMany("CustomerAccounts")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerCar", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", null)
                        .WithMany("CustomerCars")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.CarTypes", "CarTypes")
                        .WithMany("CustomerCars")
                        .HasForeignKey("CarTypesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.EnergyTypes", "EnergyTypes")
                        .WithMany("CustomerCars")
                        .HasForeignKey("EnergyTypesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarTypes");

                    b.Navigation("EnergyTypes");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerWallet", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", "AppUser")
                        .WithMany("CustomerWallets")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.WalletTypes", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.CustomerWallet", "CustomerWallet")
                        .WithMany("WalletTypes")
                        .HasForeignKey("CustomerWalletID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerWallet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EnergyControlProject.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.AppUser", b =>
                {
                    b.Navigation("CustomerAccounts");

                    b.Navigation("CustomerCars");

                    b.Navigation("CustomerWallets");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CarTypes", b =>
                {
                    b.Navigation("CustomerCars");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.CustomerWallet", b =>
                {
                    b.Navigation("WalletTypes");
                });

            modelBuilder.Entity("EnergyControlProject.EntityLayer.Concrete.EnergyTypes", b =>
                {
                    b.Navigation("CustomerCars");
                });
#pragma warning restore 612, 618
        }
    }
}
