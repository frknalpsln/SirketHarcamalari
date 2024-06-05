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
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Sirketler_SirketId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SirketId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SirketId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SirketId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SirketId",
                table: "AspNetUsers",
                column: "SirketId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Sirketler_SirketId",
                table: "AspNetUsers",
                column: "SirketId",
                principalTable: "Sirketler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
