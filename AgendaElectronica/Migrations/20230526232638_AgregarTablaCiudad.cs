using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaElectronica.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablaCiudad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "Contactos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_CiudadId",
                table: "Contactos",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_Ciudades_CiudadId",
                table: "Contactos",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_Ciudades_CiudadId",
                table: "Contactos");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Contactos_CiudadId",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "Contactos");
        }
    }
}
