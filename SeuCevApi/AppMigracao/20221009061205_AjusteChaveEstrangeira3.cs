using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeuCevApi.AppMigracao
{
    public partial class AjusteChaveEstrangeira3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IdDocumento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "Clientes");

            migrationBuilder.AddColumn<long>(
                name: "ClienteId",
                table: "Enderecos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdCliente",
                table: "Enderecos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClienteId",
                table: "Documentos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdCliente",
                table: "Documentos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_ClienteId",
                table: "Documentos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Clientes_ClienteId",
                table: "Documentos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Clientes_ClienteId",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_ClienteId",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Documentos");

            migrationBuilder.AddColumn<long>(
                name: "IdDocumento",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdEndereco",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
    }
}
