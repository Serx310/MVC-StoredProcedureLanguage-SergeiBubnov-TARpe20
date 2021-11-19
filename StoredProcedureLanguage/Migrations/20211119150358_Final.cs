using Microsoft.EntityFrameworkCore.Migrations;

namespace StoredProcedureLanguage.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainAreal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speakers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
