using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_EX2_6
{
    internal class AppIngresso
    {
        public static void Main()
        {
            Ingresso ingressoOzzy = new Ingresso();
            ingressoOzzy.Preco = 100;
            ingressoOzzy.NomeDoShow = "Ozzy";
            ingressoOzzy.QuantidadeDisponivel = 5000;

            ingressoOzzy.AlterarPreco(150);
            ingressoOzzy.AlterarQuantidade(10000);

            ingressoOzzy.ExibirInformacoes();

            ingressoOzzy.SetQuantidadeDisponivel(12000);
            Console.WriteLine(ingressoOzzy.GetQuantidadeDisponivel());

            ingressoOzzy.SetPreco(170);
            Console.WriteLine(ingressoOzzy.GetPreco());

            Console.WriteLine("========================================");

            Ingresso ingressoKiss = new Ingresso("Kiss", 130, 20000);
            ingressoKiss.ExibirInformacoes();
        }
    }
}
