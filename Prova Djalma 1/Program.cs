using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, tb, media, conceito;
            string aluno;

            Console.WriteLine("Digite o nome completo do aluno: ");
            aluno = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho: ");
            tb = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(aluno);

            media = n1 + n2 + tb;
            conceito = media / 3;

            if (conceito >= 8.5)
            {
                Console.WriteLine("Nota A");
            }

            else if (conceito >= 7.0)
            {
                Console.WriteLine("Nota B");
            }

            else if (conceito >= 6.0)
            {
                Console.WriteLine("Nota C");
            }

            else if (conceito >= 0.1)
            {
                Console.WriteLine("Nota D");
            }

            else if (conceito <= 0)
            {
                Console.WriteLine("Nota E");
            }

            Console.WriteLine(conceito);

            Console.ReadKey();
        }
    }
}