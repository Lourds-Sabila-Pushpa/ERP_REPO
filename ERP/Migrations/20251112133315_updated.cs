using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_POHDR",
                table: "POHDR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PODET",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "DOCDT",
                table: "POHDR");

            migrationBuilder.DropColumn(
                name: "CREATEBY",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "CREATEDT",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "CREATEREMARKS",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "CREATETM",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "DOCDT",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "UPDATEBY",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "UPDATEDT",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "UPDATEMARKS",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "UPDATETM",
                table: "PODET");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FRAN",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Vendor",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(22,0)")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "POHDR",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(22,0)")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DOCNO",
                table: "POHDR",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "DOCTYPE",
                table: "POHDR",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "WHSE",
                table: "POHDR",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "BRCH",
                table: "POHDR",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "PODET",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(22,0)")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DOCSRL",
                table: "PODET",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "DOCNO",
                table: "PODET",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "DOCTYPE",
                table: "PODET",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "WHSE",
                table: "PODET",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "BRCH",
                table: "PODET",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "FRAN",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(22,0)")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_POHDR",
                table: "POHDR",
                columns: new[] { "FRAN", "BRCH", "WHSE", "VENDOR", "DOCTYPE", "DOCNO" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PODET",
                table: "PODET",
                columns: new[] { "FRAN", "BRCH", "WHSE", "VENDOR", "DOCTYPE", "DOCNO", "DOCSRL" });

            migrationBuilder.CreateTable(
                name: "BRCH",
                columns: table => new
                {
                    BRCH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FRAN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NAMEAR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
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
                    table.PrimaryKey("PK_BRCH", x => new { x.FRAN, x.BRCH });
                    table.ForeignKey(
                        name: "FK_BRCH_FRAN_FRAN",
                        column: x => x.FRAN,
                        principalTable: "FRAN",
                        principalColumn: "FRAN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WHSE",
                columns: table => new
                {
                    FRAN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BRCH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WHSE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NAMEAR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
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
                    table.PrimaryKey("PK_WHSE", x => new { x.FRAN, x.BRCH, x.WHSE });
                    table.ForeignKey(
                        name: "FK_WHSE_BRCH_FRAN_BRCH",
                        columns: x => new { x.FRAN, x.BRCH },
                        principalTable: "BRCH",
                        principalColumns: new[] { "FRAN", "BRCH" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WHSE_FRAN_FRAN",
                        column: x => x.FRAN,
                        principalTable: "FRAN",
                        principalColumn: "FRAN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PODET_BRCH_FRAN_BRCH",
                table: "PODET",
                columns: new[] { "FRAN", "BRCH" },
                principalTable: "BRCH",
                principalColumns: new[] { "FRAN", "BRCH" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PODET_POHDR_FRAN_BRCH_WHSE_VENDOR_DOCTYPE_DOCNO",
                table: "PODET",
                columns: new[] { "FRAN", "BRCH", "WHSE", "VENDOR", "DOCTYPE", "DOCNO" },
                principalTable: "POHDR",
                principalColumns: new[] { "FRAN", "BRCH", "WHSE", "VENDOR", "DOCTYPE", "DOCNO" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PODET_WHSE_FRAN_BRCH_WHSE",
                table: "PODET",
                columns: new[] { "FRAN", "BRCH", "WHSE" },
                principalTable: "WHSE",
                principalColumns: new[] { "FRAN", "BRCH", "WHSE" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POHDR_BRCH_FRAN_BRCH",
                table: "POHDR",
                columns: new[] { "FRAN", "BRCH" },
                principalTable: "BRCH",
                principalColumns: new[] { "FRAN", "BRCH" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POHDR_WHSE_FRAN_BRCH_WHSE",
                table: "POHDR",
                columns: new[] { "FRAN", "BRCH", "WHSE" },
                principalTable: "WHSE",
                principalColumns: new[] { "FRAN", "BRCH", "WHSE" },
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PODET_BRCH_FRAN_BRCH",
                table: "PODET");

            migrationBuilder.DropForeignKey(
                name: "FK_PODET_POHDR_FRAN_BRCH_WHSE_VENDOR_DOCTYPE_DOCNO",
                table: "PODET");

            migrationBuilder.DropForeignKey(
                name: "FK_PODET_WHSE_FRAN_BRCH_WHSE",
                table: "PODET");

            migrationBuilder.DropForeignKey(
                name: "FK_POHDR_BRCH_FRAN_BRCH",
                table: "POHDR");

            migrationBuilder.DropForeignKey(
                name: "FK_POHDR_WHSE_FRAN_BRCH_WHSE",
                table: "POHDR");

            migrationBuilder.DropTable(
                name: "WHSE");

            migrationBuilder.DropTable(
                name: "BRCH");

            migrationBuilder.DropPrimaryKey(
                name: "PK_POHDR",
                table: "POHDR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PODET",
                table: "PODET");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FRAN",
                newName: "ID");

            migrationBuilder.AlterColumn<decimal>(
                name: "ID",
                table: "Vendor",
                type: "numeric(22,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<decimal>(
                name: "ID",
                table: "POHDR",
                type: "numeric(22,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DOCNO",
                table: "POHDR",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DOCTYPE",
                table: "POHDR",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "WHSE",
                table: "POHDR",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "BRCH",
                table: "POHDR",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DOCDT",
                table: "POHDR",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AlterColumn<decimal>(
                name: "ID",
                table: "PODET",
                type: "numeric(22,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DOCSRL",
                table: "PODET",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DOCNO",
                table: "PODET",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DOCTYPE",
                table: "PODET",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "WHSE",
                table: "PODET",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "BRCH",
                table: "PODET",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AddColumn<string>(
                name: "CREATEBY",
                table: "PODET",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "CREATEDT",
                table: "PODET",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "CREATEREMARKS",
                table: "PODET",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATETM",
                table: "PODET",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DOCDT",
                table: "PODET",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "UPDATEBY",
                table: "PODET",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "UPDATEDT",
                table: "PODET",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "UPDATEMARKS",
                table: "PODET",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UPDATETM",
                table: "PODET",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<decimal>(
                name: "ID",
                table: "FRAN",
                type: "numeric(22,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_POHDR",
                table: "POHDR",
                columns: new[] { "FRAN", "BRCH", "WHSE", "DOCTYPE", "DOCNO", "VENDOR" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PODET",
                table: "PODET",
                columns: new[] { "FRAN", "BRCH", "WHSE", "DOCTYPE", "DOCNO", "VENDOR", "DOCSRL" });
        }
    }
}
