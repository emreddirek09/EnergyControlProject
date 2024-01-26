using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_tables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Akaryakits",
                columns: table => new
                {
                    AkaryakitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkaryakitCarPlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AkaryakitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AkaryakitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akaryakits", x => x.AkaryakitID);
                });

            migrationBuilder.CreateTable(
                name: "CarTypeses",
                columns: table => new
                {
                    CarTypesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarTypesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarTypesStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypeses", x => x.CarTypesID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCars",
                columns: table => new
                {
                    CustomerCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCarPlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarEnergyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCars", x => x.CustomerCarID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerWallet",
                columns: table => new
                {
                    CustomerWalletID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerWalletName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerWalletAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerWalletDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerWallet", x => x.CustomerWalletID);
                });

            migrationBuilder.CreateTable(
                name: "EnergyTypeses",
                columns: table => new
                {
                    EnergyTypesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergyTypesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnergyTypesStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyTypeses", x => x.EnergyTypesID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Akaryakits");

            migrationBuilder.DropTable(
                name: "CarTypeses");

            migrationBuilder.DropTable(
                name: "CustomerCars");

            migrationBuilder.DropTable(
                name: "CustomerWallet");

            migrationBuilder.DropTable(
                name: "EnergyTypeses");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
