using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cadeteria.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadete",
                columns: table => new
                {
                    Id_cadete = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadete", x => x.Id_cadete);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id_cliente);
                });

            migrationBuilder.InsertData(
                table: "Cadete",
                columns: new[] { "Id_cadete", "Direccion", "Id", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { new Guid("0a9fa564-0604-4dfa-88df-3636fe395651"), "independencia", new Guid("00000000-0000-0000-0000-000000000000"), "Ana Hume", "231321231" },
                    { new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"), "independencia", new Guid("00000000-0000-0000-0000-000000000000"), "Fer Hume", "654321" },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"), "Entre rios", new Guid("00000000-0000-0000-0000-000000000000"), "Jaun Castellanos", "231321231" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id_cliente", "Direccion", "Nombre", "Referencia", "Telefono" },
                values: new object[,]
                {
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc1"), "independencia", "Lucio Hume", null, "8321156" },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"), "Entre rios", "Pancho Castellanos", null, "5231234" },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc5"), "independencia", "Val Hume", null, "975313" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadete");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
