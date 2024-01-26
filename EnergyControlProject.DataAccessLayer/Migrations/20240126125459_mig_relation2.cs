using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_relation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserID",
                table: "Statuses");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "Statuses",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Statuses_AppUserID",
                table: "Statuses",
                newName: "IX_Statuses_AppUserId");

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserId",
                table: "Statuses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Statuses",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Statuses_AppUserId",
                table: "Statuses",
                newName: "IX_Statuses_AppUserID");

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
