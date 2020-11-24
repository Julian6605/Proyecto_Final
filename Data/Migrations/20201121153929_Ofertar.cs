using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1.Data.Migrations
{
    public partial class Ofertar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Ofertar",
                columns: table => new
                {
                    IdOfertas = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Oferta = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertar", x => x.IdOfertas);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ofertar");

          
        }
    }
}
