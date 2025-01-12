using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ExamsTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exam_course_CourseId",
                table: "exam");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "exam",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_exam_course_CourseId",
                table: "exam",
                column: "CourseId",
                principalTable: "course",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exam_course_CourseId",
                table: "exam");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "exam",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_exam_course_CourseId",
                table: "exam",
                column: "CourseId",
                principalTable: "course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
