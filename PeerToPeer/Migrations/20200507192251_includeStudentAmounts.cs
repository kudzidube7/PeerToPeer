using Microsoft.EntityFrameworkCore.Migrations;

namespace PeerToPeer.Migrations
{
    public partial class includeStudentAmounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AmountLeft",
                table: "Students",
                nullable: true,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AmountReceived",
                table: "Students",
                nullable: true,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountLeft",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AmountReceived",
                table: "Students");
        }
    }
}
