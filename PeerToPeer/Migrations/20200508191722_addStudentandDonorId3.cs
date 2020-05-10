using Microsoft.EntityFrameworkCore.Migrations;

namespace PeerToPeer.Migrations
{
    public partial class addStudentandDonorId3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yearOfStudy",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yearOfStudy",
                table: "Students");
        }
    }
}
