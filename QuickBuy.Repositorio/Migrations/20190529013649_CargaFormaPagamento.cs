﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Pagamento via Boleto Bancário do Banco do Brasil.", "Boleto Bancário" });

            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Pagamento via Cartão de Crédito VISA ou MasterCard.", "Cartão de Crédito" });

            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "Pagamento via depósito em conta do Banco do Brasil.", "Depósito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
