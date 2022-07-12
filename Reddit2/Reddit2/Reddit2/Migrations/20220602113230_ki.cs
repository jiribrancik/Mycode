using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reddit2.Migrations
{
    public partial class ki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VoteValue",
                table: "Votes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoteValue",
                table: "Votes");
        }
    }
}
