using Microsoft.EntityFrameworkCore.Migrations;

namespace PeerToPeer.Migrations
{
    public partial class addStudentandDonorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donation_Donors_DonorId",
                table: "Donation");

            migrationBuilder.DropForeignKey(
                name: "FK_Donation_Students_StudentId",
                table: "Donation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donation",
                table: "Donation");

            migrationBuilder.RenameTable(
                name: "Donation",
                newName: "Donations");

            migrationBuilder.RenameIndex(
                name: "IX_Donation_StudentId",
                table: "Donations",
                newName: "IX_Donations_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Donation_DonorId",
                table: "Donations",
                newName: "IX_Donations_DonorId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DonorId",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donations",
                table: "Donations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donors_DonorId",
                table: "Donations",
                column: "DonorId",
                principalTable: "Donors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Students_StudentId",
                table: "Donations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donors_DonorId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Students_StudentId",
                table: "Donations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donations",
                table: "Donations");

            migrationBuilder.RenameTable(
                name: "Donations",
                newName: "Donation");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_StudentId",
                table: "Donation",
                newName: "IX_Donation_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_DonorId",
                table: "Donation",
                newName: "IX_Donation_DonorId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Donation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DonorId",
                table: "Donation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donation",
                table: "Donation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_Donors_DonorId",
                table: "Donation",
                column: "DonorId",
                principalTable: "Donors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_Students_StudentId",
                table: "Donation",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
