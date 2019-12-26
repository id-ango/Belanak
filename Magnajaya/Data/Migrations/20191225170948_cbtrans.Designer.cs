﻿// <auto-generated />
using System;
using Magnajaya.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Magnajaya.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191225170948_cbtrans")]
    partial class cbtrans
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Magnajaya.Models.CbBank", b =>
                {
                    b.Property<int>("CbBankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcctSet")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<decimal>("BankSld")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("ClrDate")
                        .HasColumnType("date");

                    b.Property<decimal>("Debet")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KBankSld")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KDebet")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KKredit")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KSaldo")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Kode")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<decimal>("Kredit")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KsldAwal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Kurs")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("NmBank")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("NonPpn")
                        .HasColumnType("bit");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("SldAwal")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("CbBankId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Magnajaya.Models.CbGrp", b =>
                {
                    b.Property<int>("CbGrpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrpNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaGrp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CbGrpId");

                    b.ToTable("CbGroups");
                });

            modelBuilder.Entity("Magnajaya.Models.CbSrccd", b =>
                {
                    b.Property<int>("CbSrccdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CbGrpId")
                        .HasColumnType("int");

                    b.Property<string>("GlAcct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SrcCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CbSrccdId");

                    b.HasIndex("CbGrpId");

                    b.ToTable("CbCodes");
                });

            modelBuilder.Entity("Magnajaya.Models.CbTransD", b =>
                {
                    b.Property<int>("CbTransDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcctSet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bayar")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("CbTransHId")
                        .HasColumnType("int");

                    b.Property<string>("Cek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlAcct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Jumlah")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KBayar")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KJumlah")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KTerima")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Kurs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NmBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoPrj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NonPPn")
                        .HasColumnType("bit");

                    b.Property<string>("RefNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SrcCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tanggal")
                        .HasColumnType("date");

                    b.Property<decimal>("Terima")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Tipe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CbTransDId");

                    b.HasIndex("CbTransHId")
                        .IsUnique();

                    b.ToTable("CbTransDs");
                });

            modelBuilder.Entity("Magnajaya.Models.CbTransH", b =>
                {
                    b.Property<int>("CbTransHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcctSet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Debet")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Docno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Giro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("KDebet")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("KKredit")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<decimal>("Kredit")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Kurs")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("NamaCust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaGiro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoPrj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NonPPn")
                        .HasColumnType("bit");

                    b.Property<string>("RefNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tanggal")
                        .HasColumnType("date");

                    b.Property<DateTime>("TglCair")
                        .HasColumnType("date");

                    b.Property<DateTime>("TglGiro")
                        .HasColumnType("date");

                    b.Property<DateTime>("TglGiro2")
                        .HasColumnType("date");

                    b.HasKey("CbTransHId");

                    b.ToTable("CbTransHs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Magnajaya.Models.CbSrccd", b =>
                {
                    b.HasOne("Magnajaya.Models.CbGrp", "CbGrp")
                        .WithMany()
                        .HasForeignKey("CbGrpId");
                });

            modelBuilder.Entity("Magnajaya.Models.CbTransD", b =>
                {
                    b.HasOne("Magnajaya.Models.CbTransH", null)
                        .WithOne("CbTransD")
                        .HasForeignKey("Magnajaya.Models.CbTransD", "CbTransHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
