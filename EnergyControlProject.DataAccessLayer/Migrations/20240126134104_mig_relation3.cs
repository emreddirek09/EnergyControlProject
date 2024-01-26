using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_relation3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_AppUserId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BankBranch",
                table: "CustomerAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatusCode",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankBranch",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "StatusCode",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_AppUserId",
                table: "Statuses",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_AspNetUsers_AppUserId",
                table: "Statuses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
