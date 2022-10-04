using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWork.Migrations
{
    public partial class addDescriptinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desc",
                table: "Sliders");
        }
    }
}
