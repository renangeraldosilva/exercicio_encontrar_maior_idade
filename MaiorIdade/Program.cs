using System;

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("rmem", 14);
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();

            Console.WriteLine(pessoa1.Nome);
            Console.WriteLine(pessoa2.Nome);

            Console.WriteLine("Determina qual a pessoa é mais velha");

            Console.Write("Digite o nome da 1° Pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write($"Qual a idade de {pessoa1.Nome}: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da 2° Pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write($"Qual a idade de {pessoa2.Nome}: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da 3° Pessoa: ");
            pessoa3.Nome = Console.ReadLine();
            Console.Write("Qual a idade de " + pessoa3.Nome + ": ");
            pessoa3.Idade = int.Parse(Console.ReadLine());

            if ((pessoa1.Idade > pessoa2.Idade) && (pessoa1.Idade > pessoa3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                pessoa1.ExibirDados();
            }
            else 
            {
                if ((pessoa2.Idade > pessoa1.Idade) && (pessoa2.Idade > pessoa3.Idade))
                  {
                    Console.WriteLine("A pessoa mais velha é: ");
                    pessoa2.ExibirDados();
                  }
                   else
                   {
                       if ((pessoa3.Idade > pessoa1.Idade) && (pessoa3.Idade > pessoa2.Idade))
                       {
                         Console.WriteLine("A pessoa mais velha é: ");
                        pessoa3.ExibirDados();
                       }
                       else
                       {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade.");
                       }
                   }
                    
            }

        }
    }
}
