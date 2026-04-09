using ConsoleApp1.Entities;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Digite o seu nome: ");
            string name = Console.ReadLine()!;
            Console.Clear();
            Console.WriteLine($"Bem vindo, Jogador: {name}");


            int validacaoContinuaOuSai;
            do
            {
                int numberOne = random.Next(1, 100);
                int numberTwo = random.Next(1, 100);

                Calculadora.Somar(numberOne, numberTwo);
                Console.Write($"{numberOne}+{numberTwo}: ");
                int result = int.Parse(Console.ReadLine()!);

                List<string> guardaAcertos = new List<string>();

                if (result == Calculadora.Somar(numberOne, numberTwo))
                    guardaAcertos.Add("Acertou a questão!");
                else
                    guardaAcertos.Add("Errou a questão!");

                foreach (var item in guardaAcertos)
                {
                    Console.WriteLine(item);
                }
                Painel();
                validacaoContinuaOuSai = int.Parse(Console.ReadLine()!);
            }
            while (validacaoContinuaOuSai == 1);



        }

        public static void Painel()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("1 - CONTINUAR");
            Console.WriteLine("0 - SAIR");
        }

    }
}