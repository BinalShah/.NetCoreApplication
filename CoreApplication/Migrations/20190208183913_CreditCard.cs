using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApplication.Migrations
{
    public partial class CreditCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CcType",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditCard",
                table: "Orders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CcType",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreditCard",
                table: "Orders");
        }
    }
}
