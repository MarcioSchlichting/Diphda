using Microsoft.EntityFrameworkCore.Migrations;

namespace Diphda.Infrastructure.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DIPHDA_PUBLIC");

            migrationBuilder.CreateTable(
                name: "USER",
                schema: "DIPHDA_PUBLIC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "varchar(100)", nullable: false),
                    PASSWORD = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    ACTIVE = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USER",
                schema: "DIPHDA_PUBLIC");
        }
    }
}
