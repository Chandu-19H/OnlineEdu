using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineEdu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Interests",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "NoOfCoursesEnrolled",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NoOfCoursesEnrolled",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
