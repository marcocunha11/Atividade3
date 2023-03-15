using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comissao, total;

            //usando a classe salario para criar objeto salario
            salario s;
            s = new salario();

            //Recebendo valores funcionario
            Console.WriteLine("Olá!! Qual seu nome?");
            s.nome = Console.ReadLine();
            Console.WriteLine("\n");

            //Recebendo valores salario
            Console.WriteLine("Qual seu salário atual?");
            s.embolso = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Quantas vendas você realizou?");
            s.vendas = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            comissao = s.vendas * 1.15;
            total = s.embolso + s.vendas;

            Console.WriteLine(s.nome + " recebeu o salário de: " + s.embolso.ToString("C"));
            Console.WriteLine("Comissao das vendas: " + comissao.ToString("C"));
            Console.WriteLine("Total: " + total.ToString("C"));

        }
    }
}
