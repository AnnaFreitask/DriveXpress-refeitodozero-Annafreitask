using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveXpress_refeitodozero_Annafreitask.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardapiosId",
                table: "Cardapio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cardapio_CardapiosId",
                table: "Cardapio",
                column: "CardapiosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cardapio_Cardapio_CardapiosId",
                table: "Cardapio",
                column: "CardapiosId",
                principalTable: "Cardapio",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cardapio_Cardapio_CardapiosId",
                table: "Cardapio");

            migrationBuilder.DropIndex(
                name: "IX_Cardapio_CardapiosId",
                table: "Cardapio");

            migrationBuilder.DropColumn(
                name: "CardapiosId",
                table: "Cardapio");
        }
    }
}
