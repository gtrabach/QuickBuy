using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarMensagem("Erro de preenchimento! O e-mail informado não é válido.");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarMensagem("Erro de preenchimento! Por favor informe uma senha.");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("Erro de preenchimento! Por favor informe o seu nome.");
            }

            if (string.IsNullOrEmpty(SobreNome))
            {
                AdicionarMensagem("Erro de preenchimento! Por favor informe o seu sobrenome.");
            }


        }
    }
}
