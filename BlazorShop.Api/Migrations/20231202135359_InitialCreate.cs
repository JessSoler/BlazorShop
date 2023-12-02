using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShop.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_Usuarios_UsuarioId",
                table: "Carrinhos");

            migrationBuilder.DropIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos");

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Carrinhos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: "2");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CarrinhoId",
                table: "Usuarios",
                column: "CarrinhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId",
                table: "Usuarios",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CarrinhoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Carrinhos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Carrinhos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhos_Usuarios_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
