using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Classes_ClassId",
                table: "Feats");

            migrationBuilder.DropIndex(
                name: "IX_Feats_ClassId",
                table: "Feats");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Feats");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Classes",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Classes");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Feats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feats_ClassId",
                table: "Feats",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Classes_ClassId",
                table: "Feats",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");
        }
    }
}
