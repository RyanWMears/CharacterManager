using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prerequisite",
                table: "ClassFeats");

            migrationBuilder.DropColumn(
                name: "DieSize",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "ClassFeats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "ClassFeats");

            migrationBuilder.AddColumn<string>(
                name: "Prerequisite",
                table: "ClassFeats",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DieSize",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
