using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class table_Contacts3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Contacts");
        }
    }
}
