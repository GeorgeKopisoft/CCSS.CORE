using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCSS.CORE.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Since = table.Column<DateTime>(nullable: false),
                    active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knowledge_Technology_TechId",
                        column: x => x.TechId,
                        principalTable: "Technology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_TechId",
                table: "Knowledge",
                column: "TechId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "Technology");
        }
    }
}
