using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransitoCapsuleCorp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Multa",
                columns: table => new
                {
                    MultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalizacionX = table.Column<int>(type: "int", nullable: false),
                    LocalizacionY = table.Column<int>(type: "int", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AlturaVuelo = table.Column<int>(type: "int", nullable: false),
                    Velocidad = table.Column<int>(type: "int", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TipoAuto = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Valida = table.Column<bool>(type: "bit", nullable: false),
                    Distancia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multa", x => x.MultaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Multa");
        }
    }
}
