using Microsoft.EntityFrameworkCore.Migrations;

namespace Turn.Migrations
{
    public partial class ModDataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Turns",
                table: "Turns");

            migrationBuilder.RenameTable(
                name: "Turns",
                newName: "Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_Turns_ShiftNumber",
                table: "Tickets",
                newName: "IX_Tickets_ShiftNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Turns");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ShiftNumber",
                table: "Turns",
                newName: "IX_Turns_ShiftNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turns",
                table: "Turns",
                column: "Id");
        }
    }
}
