using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2_db.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordsToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Passwords");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passwords",
                table: "Users",
                newName: "Password");
        }
    }
}
