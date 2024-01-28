using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class revize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserCustomerAccount");

            migrationBuilder.DropColumn(
                name: "AppUserCustomerAccpuntId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AppUserCustomerAccpuntId",
                table: "CustomerAccounts",
                newName: "AppUserID");

            migrationBuilder.AddColumn<DateTime>(
                name: "CustomerCarDate",
                table: "CustomerCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCars_AppUserID",
                table: "CustomerCars",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_AppUserID",
                table: "CustomerAccounts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_AspNetUsers_AppUserID",
                table: "CustomerCars",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_AspNetUsers_AppUserID",
                table: "CustomerCars");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCars_AppUserID",
                table: "CustomerCars");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccounts_AppUserID",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "CustomerCarDate",
                table: "CustomerCars");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "CustomerAccounts",
                newName: "AppUserCustomerAccpuntId");

            migrationBuilder.AddColumn<int>(
                name: "AppUserCustomerAccpuntId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppUserCustomerAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CustomerAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserCustomerAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserCustomerAccount_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserCustomerAccount_CustomerAccounts_CustomerAccountId",
                        column: x => x.CustomerAccountId,
                        principalTable: "CustomerAccounts",
                        principalColumn: "CustomerAccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserCustomerAccount_AppUserId",
                table: "AppUserCustomerAccount",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserCustomerAccount_CustomerAccountId",
                table: "AppUserCustomerAccount",
                column: "CustomerAccountId",
                unique: true);
        }
    }
}
