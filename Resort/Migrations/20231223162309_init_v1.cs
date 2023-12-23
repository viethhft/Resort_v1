using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resort.Migrations
{
    /// <inheritdoc />
    public partial class init_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageReviewResorts_Resorts_IdResort",
                table: "ImageReviewResorts");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageReviewResorts_ResortDetails_IdResort",
                table: "ImageReviewResorts",
                column: "IdResort",
                principalTable: "ResortDetails",
                principalColumn: "IdResortDetail",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageReviewResorts_ResortDetails_IdResort",
                table: "ImageReviewResorts");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageReviewResorts_Resorts_IdResort",
                table: "ImageReviewResorts",
                column: "IdResort",
                principalTable: "Resorts",
                principalColumn: "IdResort",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
