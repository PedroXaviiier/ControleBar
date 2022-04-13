using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloMesa;
using System;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Pedido Pedidos { get; set; }
        public Mesa Mesa { get; set; }

        public decimal PrecoTotal { get; set; }

        public Conta(Pedido pedidos, Mesa mesa, decimal precoTotal)
        {
            Pedidos = pedidos;
            Mesa = mesa;
            PrecoTotal = precoTotal;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Pedidos: " + Pedidos + Environment.NewLine +
                "Mesa: " + Mesa + Environment.NewLine +
                "Valor a pagar: " + PrecoTotal + Environment.NewLine;
        }
    }
}
