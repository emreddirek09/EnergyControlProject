using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarTypeses_CustomerCars_CustomerCarID",
                table: "CarTypeses");

            migrationBuilder.DropForeignKey(
                name: "FK_EnergyTypeses_CustomerCars_CustomerCarID",
                table: "EnergyTypeses");

            migrationBuilder.DropIndex(
                name: "IX_EnergyTypeses_CustomerCarID",
                table: "EnergyTypeses");

            migrationBuilder.DropIndex(
                name: "IX_CarTypeses_CustomerCarID",
                table: "CarTypeses");

            migrationBuilder.DropColumn(
                name: "CustomerCarID",
                table: "EnergyTypeses");

            migrationBuilder.DropColumn(
                name: "EnergyTypesStatus",
                table: "EnergyTypeses");

            migrationBuilder.DropColumn(
                name: "CarTypesStatus",
                table: "CarTypeses");

            migrationBuilder.DropColumn(
                name: "CustomerCarID",
                table: "CarTypeses");

            migrationBuilder.AddColumn<int>(
                name: "CarTypesID",
                table: "CustomerCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnergyTypesID",
                table: "CustomerCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_CarTypesID",
                table: "CustomerCars",
                column: "CarTypesID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_EnergyTypesID",
                table: "CustomerCars",
                column: "EnergyTypesID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_CarTypeses_CarTypesID",
                table: "CustomerCars",
                column: "CarTypesID",
                principalTable: "CarTypeses",
                principalColumn: "CarTypesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_EnergyTypeses_EnergyTypesID",
                table: "CustomerCars",
                column: "EnergyTypesID",
                principalTable: "EnergyTypeses",
                principalColumn: "EnergyTypesID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_CarTypeses_CarTypesID",
                table: "CustomerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_EnergyTypeses_EnergyTypesID",
                table: "CustomerCars");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCars_CarTypesID",
                table: "CustomerCars");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCars_EnergyTypesID",
                table: "CustomerCars");

            migrationBuilder.DropColumn(
                name: "CarTypesID",
                table: "CustomerCars");

            migrationBuilder.DropColumn(
                name: "EnergyTypesID",
                table: "CustomerCars");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCarID",
                table: "EnergyTypeses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnergyTypesStatus",
                table: "EnergyTypeses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarTypesStatus",
                table: "CarTypeses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerCarID",
                table: "CarTypeses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnergyTypeses_CustomerCarID",
                table: "EnergyTypeses",
                column: "CustomerCarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarTypeses_CustomerCarID",
                table: "CarTypeses",
                column: "CustomerCarID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarTypeses_CustomerCars_CustomerCarID",
                table: "CarTypeses",
                column: "CustomerCarID",
                principalTable: "CustomerCars",
                principalColumn: "CustomerCarID");

            migrationBuilder.AddForeignKey(
                name: "FK_EnergyTypeses_CustomerCars_CustomerCarID",
                table: "EnergyTypeses",
                column: "CustomerCarID",
                principalTable: "CustomerCars",
                principalColumn: "CustomerCarID");
        }
    }
}
