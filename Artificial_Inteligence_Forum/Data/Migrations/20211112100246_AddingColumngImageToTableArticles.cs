using Microsoft.EntityFrameworkCore.Migrations;

namespace Artificial_Inteligence_Forum.Data.Migrations
{
    public partial class AddingColumngImageToTableArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Articles");
        }
    }
}
