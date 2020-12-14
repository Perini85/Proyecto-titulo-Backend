using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTituloBackend.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "varchar(20)", nullable: false),
                    Rut = table.Column<string>(type: "varchar(10)", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(20)", nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(20)", nullable: false),
                    Correo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Rol = table.Column<string>(type: "varchar(12)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
