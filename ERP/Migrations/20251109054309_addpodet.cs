using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class addpodet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "purchaseOrder");

            migrationBuilder.CreateTable(
                name: "PODET",
                columns: table => new
                {
                    FRAN = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BRCH = table.Column<string>(type: "varchar(10)", nullable: false),
                    WHSE = table.Column<string>(type: "varchar(10)", nullable: false),
                    DOCTYPE = table.Column<string>(type: "varchar(50)", nullable: false),
                    DOCNO = table.Column<string>(type: "varchar(10)", nullable: false),
                    VENDOR = table.Column<string>(type: "varchar(10)", nullable: false),
                    DOCSRL = table.Column<string>(type: "varchar(10)", nullable: false),
                    ID = table.Column<decimal>(type: "numeric(22,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOCDT = table.Column<DateOnly>(type: "date", nullable: false),
                    REFTYPE = table.Column<string>(type: "varchar(10)", nullable: false),
                    REFNO = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    REFSRL = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    MAKE = table.Column<string>(type: "varchar(10)", nullable: false),
                    PART = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    QTY = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    PRICE = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    VATPERCENTAGE = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    VATVALUE = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    DISCOUNTVALUE = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
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
                    table.PrimaryKey("PK_PODET", x => new { x.FRAN, x.BRCH, x.WHSE, x.DOCTYPE, x.DOCNO, x.VENDOR, x.DOCSRL });
                    table.ForeignKey(
                        name: "FK_PODET_FRAN_FRAN",
                        column: x => x.FRAN,
                        principalTable: "FRAN",
                        principalColumn: "FRAN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PODET_Vendor_VENDOR",
                        column: x => x.VENDOR,
                        principalTable: "Vendor",
                        principalColumn: "VENDOR",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POHDR",
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
                    table.PrimaryKey("PK_POHDR", x => new { x.FRAN, x.BRCH, x.WHSE, x.DOCTYPE, x.DOCNO, x.VENDOR });
                    table.ForeignKey(
                        name: "FK_POHDR_FRAN_FRAN",
                        column: x => x.FRAN,
                        principalTable: "FRAN",
                        principalColumn: "FRAN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POHDR_Vendor_VENDOR",
                        column: x => x.VENDOR,
                        principalTable: "Vendor",
                        principalColumn: "VENDOR",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PODET_VENDOR",
                table: "PODET",
                column: "VENDOR");

            migrationBuilder.CreateIndex(
                name: "IX_POHDR_VENDOR",
                table: "POHDR",
                column: "VENDOR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PODET");

            migrationBuilder.DropTable(
                name: "POHDR");

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
                    CREATEBY = table.Column<string>(type: "varchar(10)", nullable: false),
                    CREATEDT = table.Column<DateOnly>(type: "date", nullable: false),
                    CREATEREMARKS = table.Column<string>(type: "varchar(200)", nullable: false),
                    CREATETM = table.Column<DateTime>(type: "datetime", nullable: false),
                    CURRENCY = table.Column<string>(type: "varchar(10)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    DOCDT = table.Column<DateOnly>(type: "date", nullable: false),
                    ID = table.Column<decimal>(type: "numeric(22,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOOFITEMS = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    TOTALVALUE = table.Column<decimal>(type: "numeric(22,0)", nullable: false),
                    UPDATEBY = table.Column<string>(type: "varchar(10)", nullable: false),
                    UPDATEDT = table.Column<DateOnly>(type: "date", nullable: false),
                    UPDATEMARKS = table.Column<string>(type: "varchar(200)", nullable: false),
                    UPDATETM = table.Column<DateTime>(type: "datetime", nullable: false),
                    VENDORREFNO = table.Column<string>(type: "varchar(10)", nullable: false),
                    VENDORREFTYPE = table.Column<string>(type: "varchar(10)", nullable: false)
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
    }
}
