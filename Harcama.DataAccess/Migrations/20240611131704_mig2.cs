using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Harcama.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KullaniciBirimYetkileri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    BirimId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciBirimYetkileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciBirimYetkileri_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciBirimYetkileri_HarcamaBirimleri_BirimId",
                        column: x => x.BirimId,
                        principalTable: "HarcamaBirimleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciSirketleri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SirketId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciSirketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciSirketleri_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciSirketleri_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciBirimYetkileri_BirimId",
                table: "KullaniciBirimYetkileri",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciBirimYetkileri_UserId",
                table: "KullaniciBirimYetkileri",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciSirketleri_SirketId",
                table: "KullaniciSirketleri",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciSirketleri_UserId",
                table: "KullaniciSirketleri",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciBirimYetkileri");

            migrationBuilder.DropTable(
                name: "KullaniciSirketleri");
        }
    }
}
