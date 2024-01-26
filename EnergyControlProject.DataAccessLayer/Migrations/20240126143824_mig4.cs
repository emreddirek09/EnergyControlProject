using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "CustomerWallet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "CustomerCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "StatusCode",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<int>(
                name: "AkaryakitCustomerCarsID",
                table: "Akaryakits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_AppUserID",
                table: "Statuses",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerWallet_AppUserID",
                table: "CustomerWallet",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_AppUserID",
                table: "CustomerCars",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Akaryakits_AkaryakitCustomerCarsID",
                table: "Akaryakits",
                column: "AkaryakitCustomerCarsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Akaryakits_CustomerCars_AkaryakitCustomerCarsID",
                table: "Akaryakits",
                column: "AkaryakitCustomerCarsID",
                principalTable: "CustomerCars",
                principalColumn: "CustomerCarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_AspNetUsers_AppUserID",
                table: "CustomerCars",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerWallet_AspNetUsers_AppUserID",
                table: "CustomerWallet",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserID",
                table: "Statuses",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Akaryakits_CustomerCars_AkaryakitCustomerCarsID",
                table: "Akaryakits");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_AspNetUsers_AppUserID",
                table: "CustomerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerWallet_AspNetUsers_AppUserID",
                table: "CustomerWallet");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserID",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_AppUserID",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerWallet_AppUserID",
                table: "CustomerWallet");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCars_AppUserID",
                table: "CustomerCars");

            migrationBuilder.DropIndex(
                name: "IX_Akaryakits_AkaryakitCustomerCarsID",
                table: "Akaryakits");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "CustomerWallet");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "CustomerCars");

            migrationBuilder.DropColumn(
                name: "AkaryakitCustomerCarsID",
                table: "Akaryakits");

            migrationBuilder.AlterColumn<string>(
                name: "StatusCode",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
