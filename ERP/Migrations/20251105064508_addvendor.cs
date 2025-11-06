using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class addvendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendor",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "venName",
                table: "Vendor",
                newName: "VENDOR");

            migrationBuilder.AddColumn<string>(
                name: "ADDRESS",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CREATEBY",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "CREATEDT",
                table: "Vendor",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "CREATEREMARKS",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATETM",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NAME",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NAMEAR",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PHONE",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UPDATEBY",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "UPDATEDT",
                table: "Vendor",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "UPDATEMARKS",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UPDATETM",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VATNO",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADDRESS",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CREATEBY",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CREATEDT",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CREATEREMARKS",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CREATETM",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "NAME",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "NAMEAR",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "PHONE",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UPDATEBY",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UPDATEDT",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UPDATEMARKS",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UPDATETM",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "VATNO",
                table: "Vendor");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vendor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VENDOR",
                table: "Vendor",
                newName: "venName");
        }
    }
}
