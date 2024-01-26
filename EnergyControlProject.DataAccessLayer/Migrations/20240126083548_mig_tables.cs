using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyControlProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "StatusCode",
                table: "AspNetUsers");
        }
    }
}
