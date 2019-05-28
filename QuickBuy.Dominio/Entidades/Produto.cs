using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("Erro de Preenchimento! O nome do produto não pode ser vazio.");
            }

            if (Preco <= 0)
            {
                AdicionarMensagem("Erro de Preenchimento! O preço do produto não pode ser menor ou igual a zero.");
            }
        }
    }
}
