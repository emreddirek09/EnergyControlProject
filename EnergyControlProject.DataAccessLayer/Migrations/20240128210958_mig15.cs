using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCarPlaka",
                table: "EnergyTypeses");

            migrationBuilder.DropColumn(
                name: "EnergyAmount",
                table: "EnergyTypeses");

            migrationBuilder.DropColumn(
                name: "EnergyDate",
                table: "EnergyTypeses");

            migrationBuilder.DropColumn(
                name: "Yüzdeİndirim",
                table: "EnergyTypeses");

            migrationBuilder.DropColumn(
                name: "ÖdemeYöntemi",
                table: "EnergyTypeses");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCarPlaka",
                table: "CustomerWallet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCarPlaka",
                table: "CustomerWallet");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCarPlaka",
                table: "EnergyTypeses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "EnergyAmount",
                table: "EnergyTypeses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "EnergyDate",
                table: "EnergyTypeses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Yüzdeİndirim",
                table: "EnergyTypeses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ÖdemeYöntemi",
                table: "EnergyTypeses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
