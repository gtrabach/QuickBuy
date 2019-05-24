using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (Id == 0)
            {
                AdicionarMensagem("Erro de Preenchimento! O Id do Item do Pedido não foi informado.");
            }

            if (ProdutoId == 0)
            {
                AdicionarMensagem("Erro de Preenchimento! O produto informado não existe.");
            }

            if (Quantidade < 1)
            {
                AdicionarMensagem("Erro de preenchimento! A quantidade mínima de compra deste produto é 1.");
            }
        }
    }
}
