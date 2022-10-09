using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeuCevApi.AppMigracao
{
    public partial class AjustesBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TiposPlanos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TiposClientes",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Ofertas",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Ofertas",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Enderecos",
                type: "VARCHAR(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Enderecos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                table: "Enderecos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Enderecos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "VARCHAR(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Documentos",
                type: "VARCHAR(55)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Documentos",
                type: "VARCHAR(55)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "Clientes",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Clientes",
                type: "VARCHAR(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<long>(
                name: "DocumentoId",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "idx_tipoplano_id",
                table: "TiposPlanos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_tipocliente_id",
                table: "TiposClientes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_produto_id",
                table: "Produtos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_oferta_id",
                table: "Ofertas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_endereco_id",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_documento_id",
                table: "Documentos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_cliente_id",
                table: "Clientes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DocumentoId",
                table: "Clientes",
                column: "DocumentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Documentos_DocumentoId",
                table: "Clientes",
                column: "DocumentoId",
                principalTable: "Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Documentos_DocumentoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "idx_tipoplano_id",
                table: "TiposPlanos");

            migrationBuilder.DropIndex(
                name: "idx_tipocliente_id",
                table: "TiposClientes");

            migrationBuilder.DropIndex(
                name: "idx_produto_id",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "idx_oferta_id",
                table: "Ofertas");

            migrationBuilder.DropIndex(
                name: "idx_endereco_id",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "idx_documento_id",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "idx_cliente_id",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DocumentoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DocumentoId",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TiposPlanos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TiposClientes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Ofertas",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Ofertas",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Enderecos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(4)");

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Enderecos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                table: "Enderecos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Enderecos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Documentos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(55)");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Documentos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(55)");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "Clientes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Clientes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");
        }
    }
}
