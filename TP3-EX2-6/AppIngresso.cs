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
            Ingresso ingresso = new Ingresso();
            ingresso.Preco = 100;
            ingresso.NomeDoShow = "Ozzy";
            ingresso.QuantidadeDisponivel = 5000;

            ingresso.AlterarPreco(150);
            ingresso.AlterarQuantidade(10000);

            ingresso.ExibirInformacoes();

            ingresso.SetQuantidadeDisponivel(12000);
            Console.WriteLine(ingresso.GetQuantidadeDisponivel());

            ingresso.SetPreco(170);
            Console.WriteLine(ingresso.GetPreco());
        }
    }
}
