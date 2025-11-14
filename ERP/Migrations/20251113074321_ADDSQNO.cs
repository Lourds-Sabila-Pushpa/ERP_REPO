using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class ADDSQNO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CREATEDT",
                table: "POHDR");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATETM",
                table: "POHDR",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "UPDATEMARKS",
                table: "POHDR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATEDT",
                table: "POHDR",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "UPDATEBY",
                table: "POHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATETM",
                table: "POHDR",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "CREATEREMARKS",
                table: "POHDR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "CREATEBY",
                table: "POHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "POHDR",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SEQNO",
                table: "POHDR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SEQNOPREFIX",
                table: "POHDR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CREATEBY",
                table: "PODET",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CREATEREMARKS",
                table: "PODET",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATETM",
                table: "PODET",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "PODET",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UPDATEBY",
                table: "PODET",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UPDATEDT",
                table: "PODET",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UPDATEMARKS",
                table: "PODET",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UPDATETM",
                table: "PODET",
                type: "datetime",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "POHDR");

            migrationBuilder.DropColumn(
                name: "SEQNO",
                table: "POHDR");

            migrationBuilder.DropColumn(
                name: "SEQNOPREFIX",
                table: "POHDR");

            migrationBuilder.DropColumn(
                name: "CREATEBY",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "CREATEREMARKS",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "CREATETM",
                table: "PODET");

            migrationBuilder.DropColumn(
                name: "CreateDate",
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATETM",
                table: "POHDR",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UPDATEMARKS",
                table: "POHDR",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "UPDATEDT",
                table: "POHDR",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UPDATEBY",
                table: "POHDR",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATETM",
                table: "POHDR",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CREATEREMARKS",
                table: "POHDR",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CREATEBY",
                table: "POHDR",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CREATEDT",
                table: "POHDR",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
