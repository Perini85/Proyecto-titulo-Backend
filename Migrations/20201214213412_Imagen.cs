using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTituloBackend.Migrations
{
    public partial class Imagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagen",
                table: "Documentos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagen",
                table: "Documentos");
        }
    }
}
