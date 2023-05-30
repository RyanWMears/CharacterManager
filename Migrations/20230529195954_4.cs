using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Feats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DieSize",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HitDie",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DieSize",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "HitDie",
                table: "Classes");
        }
    }
}
