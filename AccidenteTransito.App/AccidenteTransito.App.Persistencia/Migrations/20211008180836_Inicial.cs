using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccidenteTransito.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<double>(type: "float", nullable: false),
                    Longitud = table.Column<double>(type: "float", nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoAccidente = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroPlaca = table.Column<int>(type: "int", nullable: true),
                    Rango = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaExpedicionDocumento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DireccionCasa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgenteVial = table.Column<int>(type: "int", nullable: true),
                    Alcoholemia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentaLicencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Soat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccidentePersonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accidenteId = table.Column<int>(type: "int", nullable: false),
                    personaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidentePersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccidentePersonas_Accidentes_accidenteId",
                        column: x => x.accidenteId,
                        principalTable: "Accidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccidentePersonas_Personas_personaId",
                        column: x => x.personaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccidenteVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accidenteId = table.Column<int>(type: "int", nullable: false),
                    vehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidenteVehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccidenteVehiculos_Accidentes_accidenteId",
                        column: x => x.accidenteId,
                        principalTable: "Accidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccidenteVehiculos_Vehiculos_vehiculoId",
                        column: x => x.vehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccidentePersonas_accidenteId",
                table: "AccidentePersonas",
                column: "accidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_AccidentePersonas_personaId",
                table: "AccidentePersonas",
                column: "personaId");

            migrationBuilder.CreateIndex(
                name: "IX_AccidenteVehiculos_accidenteId",
                table: "AccidenteVehiculos",
                column: "accidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_AccidenteVehiculos_vehiculoId",
                table: "AccidenteVehiculos",
                column: "vehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidentePersonas");

            migrationBuilder.DropTable(
                name: "AccidenteVehiculos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Accidentes");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
