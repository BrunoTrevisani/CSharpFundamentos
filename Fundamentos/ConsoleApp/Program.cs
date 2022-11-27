using DataApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 4");
            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.SetIdade(18);
            //pessoa1.SetNome("Carlos");
            //Console.WriteLine($"\tNome: {pessoa1.GetNome()} \n\tIdade: {pessoa1.GetIdade()}");
            TiposNumericos tn = new TiposNumericos();
            //tn.Executar();
            TiposNumericos3.Executar();
            Console.ReadLine();
        }
    }
}
