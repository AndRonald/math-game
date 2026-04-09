using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Bem vindo, Jogador: {name}");

            int validacaoContinuaOuSai;
            do
            {
                Painel();
                validacaoContinuaOuSai = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                Random random = new Random();
                
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