using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorNews.Server.Migrations
{
    public partial class TopicHost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "Topics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Host",
                table: "Topics");
        }
    }
}
