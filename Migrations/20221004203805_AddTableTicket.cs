using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turn.Migrations
{
    public partial class AddTableTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesType = table.Column<string>(maxLength: 5, nullable: false),
                    ShiftNumber = table.Column<int>(nullable: false),
                    Stand = table.Column<string>(maxLength: 20, nullable: true),
                    ExpeditionDate = table.Column<DateTime>(nullable: false),
                    AttentionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turns", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turns_ShiftNumber",
                table: "Turns",
                column: "ShiftNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turns");
        }
    }
}
