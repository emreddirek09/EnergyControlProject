using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerCarID",
                table: "EnergyTypeses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerCarType",
                table: "CustomerCars",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerCarEnergyType",
                table: "CustomerCars",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CustomerCarID",
                table: "CarTypeses");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCarType",
                table: "CustomerCars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCarEnergyType",
                table: "CustomerCars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
