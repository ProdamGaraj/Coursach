using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Coupons_CardId",
                table: "Coupons",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Cards_CardId",
                table: "Coupons",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Cards_CardId",
                table: "Coupons");

            migrationBuilder.DropIndex(
                name: "IX_Coupons_CardId",
                table: "Coupons");
        }
    }
}
