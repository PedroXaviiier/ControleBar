using ControleBar.ConsoleApp.Compartilhado;
using System;


namespace ControleBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {

        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome do produto: " + Nome + Environment.NewLine +
                "preco do produto R$" + Preco + Environment.NewLine;
        }
    }
}
