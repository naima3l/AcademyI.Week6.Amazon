using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyI.Week6.Amazon.EF.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prodotti",
                columns: table => new
                {
                    Codice = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipologia = table.Column<int>(type: "int", nullable: false),
                    PrezzoPubblico = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrezzoFornitore = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodotti", x => x.Codice);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prodotti");
        }
    }
}
