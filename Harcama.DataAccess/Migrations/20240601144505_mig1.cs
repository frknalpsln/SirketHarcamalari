using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Harcama.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HarcamaBirimleri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BirimAdi = table.Column<string>(type: "text", nullable: false),
                    BirimKodu = table.Column<string>(type: "text", nullable: false),
                    BirimYetkili = table.Column<string>(type: "text", nullable: false),
                    BirimYetkiliTelefon = table.Column<string>(type: "text", nullable: false),
                    Durum = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarcamaBirimleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Tc = table.Column<string>(type: "text", nullable: false),
                    Adi = table.Column<string>(type: "text", nullable: false),
                    Soyadi = table.Column<string>(type: "text", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    TelefonNo = table.Column<string>(type: "text", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sirketler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SirketAdi = table.Column<string>(type: "text", nullable: false),
                    SirketKodu = table.Column<string>(type: "text", nullable: false),
                    Durum = table.Column<bool>(type: "boolean", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    TelefonNo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sirketler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HarcamaTalepleri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Tarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TalepteBulunanId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarcamaTalepleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarcamaTalepleri_Kullanicilar_TalepteBulunanId",
                        column: x => x.TalepteBulunanId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciBirimYetkileri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KullaniciId = table.Column<Guid>(type: "uuid", nullable: false),
                    BirimId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciBirimYetkileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciBirimYetkileri_HarcamaBirimleri_BirimId",
                        column: x => x.BirimId,
                        principalTable: "HarcamaBirimleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciBirimYetkileri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciSirketleri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KullaniciId = table.Column<Guid>(type: "uuid", nullable: false),
                    SirketId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciSirketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciSirketleri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciSirketleri_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjeTanimlari",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjeAdi = table.Column<string>(type: "text", nullable: false),
                    ProjeTanimi = table.Column<string>(type: "text", nullable: false),
                    ProjeBaslangic = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProjeYetkilisi = table.Column<string>(type: "text", nullable: false),
                    SirketId = table.Column<Guid>(type: "uuid", nullable: false),
                    BirimId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeTanimlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjeTanimlari_HarcamaBirimleri_BirimId",
                        column: x => x.BirimId,
                        principalTable: "HarcamaBirimleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjeTanimlari_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HarcamaTalepleri_TalepteBulunanId",
                table: "HarcamaTalepleri",
                column: "TalepteBulunanId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciBirimYetkileri_BirimId",
                table: "KullaniciBirimYetkileri",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciBirimYetkileri_KullaniciId",
                table: "KullaniciBirimYetkileri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciSirketleri_KullaniciId",
                table: "KullaniciSirketleri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciSirketleri_SirketId",
                table: "KullaniciSirketleri",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjeTanimlari_BirimId",
                table: "ProjeTanimlari",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjeTanimlari_SirketId",
                table: "ProjeTanimlari",
                column: "SirketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HarcamaTalepleri");

            migrationBuilder.DropTable(
                name: "KullaniciBirimYetkileri");

            migrationBuilder.DropTable(
                name: "KullaniciSirketleri");

            migrationBuilder.DropTable(
                name: "ProjeTanimlari");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "HarcamaBirimleri");

            migrationBuilder.DropTable(
                name: "Sirketler");
        }
    }
}
