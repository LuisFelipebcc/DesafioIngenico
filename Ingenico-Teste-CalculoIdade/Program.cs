using System;

namespace Ingenico_Teste_CalculoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataNascimento = new DateTime();

            Console.WriteLine("Digite Sua Datada de Nascimento. Ex: 14/05/1995");
            var teste = Console.ReadLine();
            dataNascimento = Convert.ToDateTime(teste);
            Console.WriteLine(dataNascimento);
            Console.Read();

        }

        //private int CalcularIdade(int ano)
        //{

        //    var AnoAtual = DateTime.Now.Year;



        //}
    }
}
