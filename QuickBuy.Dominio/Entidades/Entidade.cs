using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> MensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return MensagensValidacao ?? (MensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();

        protected bool IsValid
        {
            get { return !MensagemValidacao.Any(); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string msg)
        {
            MensagemValidacao.Add(msg);
        }
    }
}
