using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeToDbApproach.Migrations
{
    public partial class UpdateStudentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "StudentMaster",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "StudentMaster",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentMaster_TeacherId",
                table: "StudentMaster",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentMaster_Teachers_TeacherId",
                table: "StudentMaster",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentMaster_Teachers_TeacherId",
                table: "StudentMaster");

            migrationBuilder.DropIndex(
                name: "IX_StudentMaster_TeacherId",
                table: "StudentMaster");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "StudentMaster");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "StudentMaster");
        }
    }
}
