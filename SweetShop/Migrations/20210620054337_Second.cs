using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetShop.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatBook_Flavors_FlavorId",
                table: "TreatBook");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatBook_Treats_TreatId",
                table: "TreatBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatBook",
                table: "TreatBook");

            migrationBuilder.RenameTable(
                name: "TreatBook",
                newName: "TreatFlavors");

            migrationBuilder.RenameIndex(
                name: "IX_TreatBook_TreatId",
                table: "TreatFlavors",
                newName: "IX_TreatFlavors_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_TreatBook_FlavorId",
                table: "TreatFlavors",
                newName: "IX_TreatFlavors_FlavorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatFlavors",
                table: "TreatFlavors",
                column: "TreatFlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_Flavors_FlavorId",
                table: "TreatFlavors",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_Treats_TreatId",
                table: "TreatFlavors",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_Flavors_FlavorId",
                table: "TreatFlavors");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_Treats_TreatId",
                table: "TreatFlavors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatFlavors",
                table: "TreatFlavors");

            migrationBuilder.RenameTable(
                name: "TreatFlavors",
                newName: "TreatBook");

            migrationBuilder.RenameIndex(
                name: "IX_TreatFlavors_TreatId",
                table: "TreatBook",
                newName: "IX_TreatBook_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_TreatFlavors_FlavorId",
                table: "TreatBook",
                newName: "IX_TreatBook_FlavorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatBook",
                table: "TreatBook",
                column: "TreatFlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatBook_Flavors_FlavorId",
                table: "TreatBook",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatBook_Treats_TreatId",
                table: "TreatBook",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
