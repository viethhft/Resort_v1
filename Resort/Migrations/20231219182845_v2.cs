using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resort.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Resorts_ResortIdResort",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rates",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Rates_IdUser",
                table: "Rates");

            migrationBuilder.DropColumn(
                name: "IdRate",
                table: "Rates");

            migrationBuilder.RenameColumn(
                name: "ResortIdResort",
                table: "Rates",
                newName: "IdResort");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ResortIdResort",
                table: "Rates",
                newName: "IX_Rates_IdResort");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Resorts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rates",
                table: "Rates",
                columns: new[] { "IdUser", "IdResort" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Resorts_IdResort",
                table: "Rates",
                column: "IdResort",
                principalTable: "Resorts",
                principalColumn: "IdResort",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Resorts_IdResort",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rates",
                table: "Rates");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Resorts");

            migrationBuilder.RenameColumn(
                name: "IdResort",
                table: "Rates",
                newName: "ResortIdResort");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_IdResort",
                table: "Rates",
                newName: "IX_Rates_ResortIdResort");

            migrationBuilder.AddColumn<int>(
                name: "IdRate",
                table: "Rates",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rates",
                table: "Rates",
                column: "IdRate");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_IdUser",
                table: "Rates",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Resorts_ResortIdResort",
                table: "Rates",
                column: "ResortIdResort",
                principalTable: "Resorts",
                principalColumn: "IdResort",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
