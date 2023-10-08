Uusing Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveXpress_refeitodozero_Annafreitask.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinkDto_Usuario_UsuarioId",
                table: "LinkDto");

            migrationBuilder.DropForeignKey(
                name: "FK_RestauranteUsuarios_Usuario_UsuarioId",
                table: "RestauranteUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LinkDto_Usuarios_UsuarioId",
                table: "LinkDto",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestauranteUsuarios_Usuarios_UsuarioId",
                table: "RestauranteUsuarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinkDto_Usuarios_UsuarioId",
                table: "LinkDto");

            migrationBuilder.DropForeignKey(
                name: "FK_RestauranteUsuarios_Usuarios_UsuarioId",
                table: "RestauranteUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LinkDto_Usuario_UsuarioId",
                table: "LinkDto",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestauranteUsuarios_Usuario_UsuarioId",
                table: "RestauranteUsuarios",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
