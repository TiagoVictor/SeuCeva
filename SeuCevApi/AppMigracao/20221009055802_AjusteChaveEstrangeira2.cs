using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeuCevApi.AppMigracao
{
    public partial class AjusteChaveEstrangeira2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Documentos_DocumentoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_EnderecoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DocumentoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DocumentoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Clientes");

            migrationBuilder.AlterColumn<long>(
                name: "IdEndereco",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "IdDocumento",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdDocumento",
                table: "Clientes",
                column: "IdDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdEndereco",
                table: "Clientes",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Documentos_IdDocumento",
                table: "Clientes",
                column: "IdDocumento",
                principalTable: "Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_IdEndereco",
                table: "Clientes",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Documentos_IdDocumento",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_IdEndereco",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdDocumento",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdEndereco",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "IdEndereco",
                table: "Clientes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "IdDocumento",
                table: "Clientes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "DocumentoId",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EnderecoId",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DocumentoId",
                table: "Clientes",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Documentos_DocumentoId",
                table: "Clientes",
                column: "DocumentoId",
                principalTable: "Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_EnderecoId",
                table: "Clientes",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
