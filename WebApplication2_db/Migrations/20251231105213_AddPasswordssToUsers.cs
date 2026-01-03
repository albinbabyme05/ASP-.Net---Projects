using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2_db.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordssToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passwords",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Passwordss",
                table: "Users",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passwordss",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Passwords",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
