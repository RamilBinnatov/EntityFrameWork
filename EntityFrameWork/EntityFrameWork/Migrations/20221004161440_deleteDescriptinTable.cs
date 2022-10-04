using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWork.Migrations
{
    public partial class deleteDescriptinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desc",
                table: "Sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
