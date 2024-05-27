using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDemoNetCore.Migrations
{
    /// <inheritdoc />
    public partial class v3newgradeKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeID",
                table: "Students",
                column: "GradeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "GradeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradeID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradeID",
                table: "Students");
        }
    }
}
