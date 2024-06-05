﻿// <auto-generated />
using System;
using Harcama.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Harcama.DataAccess.Migrations
{
    [DbContext(typeof(HarcamaDbContext))]
    partial class HarcamaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Harcama.Entities.Concrete.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.HarcamaBirimleri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BirimAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BirimKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BirimYetkili")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BirimYetkiliTelefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Durum")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("HarcamaBirimleri");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.HarcamaTalepleri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OnaylandiMi")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HarcamaTalepleri");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.KullaniciBirimYetkileri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BirimId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("KullaniciId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciBirimYetkileri");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.KullaniciSirketleri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("KullaniciId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SirketId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("SirketId");

                    b.ToTable("KullaniciSirketleri");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.ProjeTanimlari", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BirimId")
                        .HasColumnType("uuid");

                    b.Property<string>("ProjeAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ProjeBaslangic")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ProjeTanimi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjeYetkilisi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SirketId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.HasIndex("SirketId");

                    b.ToTable("ProjeTanimlari");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.Sirket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Durum")
                        .HasColumnType("boolean");

                    b.Property<string>("SirketAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SirketKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.HarcamaTalepleri", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.KullaniciBirimYetkileri", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.HarcamaBirimleri", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harcama.Entities.Concrete.AppUser", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.KullaniciSirketleri", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppUser", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harcama.Entities.Concrete.Sirket", "Sirket")
                        .WithMany()
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Sirket");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.ProjeTanimlari", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.HarcamaBirimleri", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harcama.Entities.Concrete.Sirket", "Sirket")
                        .WithMany()
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");

                    b.Navigation("Sirket");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harcama.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
