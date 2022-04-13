using ControleBar.ConsoleApp.Compartilhado;
using System;


namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string Assentos { get; set; }
        public string Cor { get; set; }

        public Mesa(string assentos, string cor)
        {
            Assentos = assentos;
            Cor = cor;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nunemro de assentos: " + Assentos + Environment.NewLine +
                "Cor da mesa: " + Cor + Environment.NewLine;
        }
    }
}
