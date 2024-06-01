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

                    b.Property<Guid>("TalepteBulunanId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("TalepteBulunanId");

                    b.ToTable("HarcamaTalepleri");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.Kullanici", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
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

            modelBuilder.Entity("Harcama.Entities.Concrete.HarcamaTalepleri", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.Kullanici", "TalepteBulunan")
                        .WithMany()
                        .HasForeignKey("TalepteBulunanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TalepteBulunan");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.KullaniciBirimYetkileri", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.HarcamaBirimleri", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harcama.Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Harcama.Entities.Concrete.KullaniciSirketleri", b =>
                {
                    b.HasOne("Harcama.Entities.Concrete.Kullanici", "Kullanici")
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
#pragma warning restore 612, 618
        }
    }
}