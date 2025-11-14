using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class addtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FRAN",
                columns: table => new
                {
                    FRAN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID = table.Column<decimal>(type: "numeric(22,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    VENDOR = table.Column<string>(type: "varchar(10)", nullable: false),
                    ID = table.Column<decimal>(type: "numeric(22,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "varchar(100)", nullable: false),
                    NAMEAR = table.Column<string>(type: "varchar(100)", nullable: false),
                    PHONE = table.Column<string>(type: "varchar(50)", nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(100)", nullable: false),
                    ADDRESS = table.Column<string>(type: "varchar(100)", nullable: false),
                    VATNO = table.Column<string>(type: "varchar(50)", nullable: false),
                    CREATEDT = table.Column<DateOnly>(type: "date", nullable: false),
                    CREATETM = table.Column<DateTime>(type: "datetime", nullable: false),
                    CREATEBY = table.Column<string>(type: "varchar(10)", nullable: false),
                    CREATEREMARKS = table.Column<string>(type: "varchar(200)", nullable: false),
                    UPDATEDT = table.Column<DateOnly>(type: "date", nullable: false),
                    UPDATETM = table.Column<DateTime>(type: "datetime", nullable: false),
                    UPDATEBY = table.Column<string>(type: "varchar(10)", nullable: false),
                    UPDATEMARKS = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VENDOR);
                });

            migrationBuilder.CreateTable(
                name: "purchaseOrder",
                columns: table => new
                {
                    FRAN = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BRCH = table.Column<string>(type: "varchar(10)", nullable: false),
                    WHSE = table.Column<string>(type: "varchar(10)", nullable: false),
                    DOCTYPE = table.Column<string>(type: "varchar(50)", nullable: false),
                    DOCNO = table.Column<string>(type: "varchar(10)", nullable: false),
                    VENDOR = table.Column<string>(type: "varchar(10)", nullable: false),
                    ID = table.Column<decimal>(type: "numeric(22,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOCDT = table.Column<DateOnly>(type: "date", nullable: false),
                    VENDORREFTYPE = table.Column<string>(type: "varchar(10)", nullable: false),
                    VENDORREFNO = table.Column<string>(type: "varchar(10)", nullable: false),
                    CURRENCY = table.Column<string>(type: "varchar(10)", nullable: false),
                    NOOFITEMS = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    TOTALVALUE = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    CREATEDT = table.Column<DateOnly>(type: "date", nullable: false),
                    CREATETM = table.Column<DateTime>(type: "datetime", nullable: false),
                    CREATEBY = table.Column<string>(type: "varchar(10)", nullable: false),
                    CREATEREMARKS = table.Column<string>(type: "varchar(200)", nullable: false),
                    UPDATEDT = table.Column<DateOnly>(type: "date", nullable: false),
                    UPDATETM = table.Column<DateTime>(type: "datetime", nullable: false),
                    UPDATEBY = table.Column<string>(type: "varchar(10)", nullable: false),
                    UPDATEMARKS = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseOrder", x => new { x.FRAN, x.BRCH, x.WHSE, x.DOCTYPE, x.DOCNO, x.VENDOR });
                    table.ForeignKey(
                        name: "FK_purchaseOrder_FRAN_FRAN",
                        column: x => x.FRAN,
                        principalTable: "FRAN",
                        principalColumn: "FRAN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseOrder_Vendor_VENDOR",
                        column: x => x.VENDOR,
                        principalTable: "Vendor",
                        principalColumn: "VENDOR",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrder_VENDOR",
                table: "purchaseOrder",
                column: "VENDOR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "purchaseOrder");

            migrationBuilder.DropTable(
                name: "FRAN");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
