using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int correctAnswer = 0;
            int wrongAnswer = 0;


            var resultOfTheSum = new ResultModel();

            int validationExit = 1;
            do
            {
                Painel();
                if (!(int.TryParse(Console.ReadLine(), out validationExit)))
                    validationExit = 10;

                switch (validationExit)
                {
                    case 1:
                        Console.WriteLine();
                        for (int i = 0; i < 5; i++)
                        {
                            int numberOne = random.Next(1, 100);
                            int numberTwo = random.Next(1, 100);
                            Somar(numberOne, numberTwo);
                            Console.Write($"{numberOne}+{numberTwo}: ");
                            int result = int.Parse(Console.ReadLine()!);

                            if (result == Somar(numberOne, numberTwo))
                            {
                                resultOfTheSum.previousAccountSafekeeping.Add($"{numberOne} + {numberTwo}: {result}");
                                resultOfTheSum.Corrects += 1;
                            }
                            else
                            {
                                resultOfTheSum.previousAccountSafekeeping.Add($"{numberOne} + {numberTwo}: {result}");
                                resultOfTheSum.Erros += 1;
                            }
                        }

                        Console.WriteLine("after leaving, errors will be counted");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        if (!(resultOfTheSum.previousAccountSafekeeping.Count == 0))
                        {
                            Console.WriteLine("Outcome of the questions: ");
                            for (int i = 0; i < resultOfTheSum.previousAccountSafekeeping.Count; i++)
                            {
                                Console.WriteLine($"{i}: {resultOfTheSum.previousAccountSafekeeping[i]}");
                            }
                        }
                        else
                            Console.WriteLine("Não há registros de resultados");
                        break;

                    case 3:
                        throw new NotImplementedException();
                    default:
                        if (validationExit != 0)
                            Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
            while (validationExit != 0);

            Console.WriteLine($"Result soma:\nCorrect: {resultOfTheSum.Corrects}\nErrors: {resultOfTheSum.Erros}");
        }

        public static void Painel()
        {
            Console.WriteLine("select an option:");
            Console.WriteLine("----------------------");
            Console.WriteLine("1 - to add");
            Console.WriteLine("2 - result of sums");
            Console.WriteLine("----------------------");
            Console.WriteLine("3 - to subtraction");
            Console.WriteLine("4 - result of subtraction");
            Console.WriteLine("----------------------");
            Console.WriteLine("5 - to multiplication");
            Console.WriteLine("6 - result of multiplication");
            Console.WriteLine("----------------------");
            Console.WriteLine("7 - to division");
            Console.WriteLine("8 - result of division");
            Console.WriteLine("----------------------");
            Console.WriteLine("0 - exit");
            Console.WriteLine();
        }

        public static int Somar(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico...
            //if(a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}

            return a + b;
        }

        public static int Subtrait(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico..
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}

            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico..
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico..
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}
            return a / b;
        }
        //por exemplo, quero que a função de soma seja com número aleatório. mas questão é que ela vai de fato somar, mas preciso desse valor retornado..
        //como posso pegar dois números aletórios e somar eles e depois retornar o resultado?

    }
}