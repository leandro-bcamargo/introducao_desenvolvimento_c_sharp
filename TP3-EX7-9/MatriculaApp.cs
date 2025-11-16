using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_EX7_9
{
    internal class MatriculaApp
    {
        public static void Main()
        {
            Matricula matricula = new Matricula();
            matricula.NomeDoAluno = "Leandro Camargo";
            matricula.Curso = "ADS";
            matricula.NumeroMatricula = 12345;
            matricula.Situacao = "Pendente";
            matricula.DataInicial = "16/11/2025";

            matricula.Trancar();
            Console.WriteLine(matricula.Situacao);
            matricula.Reativar();
            Console.WriteLine(matricula.Situacao);

            matricula.ExibirInformacoes();

        }
    }
}
