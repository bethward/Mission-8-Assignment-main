using Microsoft.EntityFrameworkCore.Migrations;

namespace BookProject.Migrations
{
    public partial class addReceivedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PurchaseReceived",
                table: "Purchase",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseReceived",
                table: "Purchase");
        }
    }
}
