using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserID",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_AppUserID",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Statuses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_AppUserID",
                table: "Statuses",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserID",
                table: "Statuses",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
