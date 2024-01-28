using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class testAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_AspNetUsers_AppUserID",
                table: "CustomerCars");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCars_AppUserID",
                table: "CustomerCars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_AppUserID",
                table: "CustomerCars",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_AspNetUsers_AppUserID",
                table: "CustomerCars",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
