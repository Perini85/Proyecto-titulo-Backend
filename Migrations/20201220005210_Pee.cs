using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTituloBackend.Migrations
{
    public partial class Pee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Documentos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Documentos");
        }
    }
}
