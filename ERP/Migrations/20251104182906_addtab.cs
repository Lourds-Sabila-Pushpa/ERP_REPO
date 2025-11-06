using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class addtab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FRAN",
                columns: table => new
                {
                    FRAN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NAMEAR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CREATEDT = table.Column<DateTime>(type: "date", nullable: true),
                    CREATETM = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREATEBY = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CREATEREMARKS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UPDATEDT = table.Column<DateTime>(type: "date", nullable: true),
                    UPDATETM = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEBY = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UPDATEMARKS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FRAN", x => x.FRAN);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    venName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FRAN");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
