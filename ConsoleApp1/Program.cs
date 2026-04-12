using System;
using ConsoleApp1.Models;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            var resultOfTheSum = new ResultModel();
            var resultOfTheSubtraction = new ResultModel();
            var resultOfTheMultiplication = new ResultModel();
            var resultOfTheDivision = new ResultModel();

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
                            Console.Write($"{numberOne}+{numberTwo}: ");

                            if (int.TryParse(Console.ReadLine(), out int result))
                            {
                                if (result == Operations.Addition(numberOne, numberTwo))
                                    resultOfTheSum.Corrects += 1;
                                else
                                    resultOfTheSum.Erros += 1;

                                resultOfTheSum.PreviousAccountSafekeeping.Add($"{numberOne} + {numberTwo}: {result}");
                            }
                            else
                                Console.WriteLine("Invalid input");
                        }
                        Console.WriteLine($"Result soma:\nCorrect: {resultOfTheSum.Corrects}\nErrors: {resultOfTheSum.Erros}");
                        break;

                    case 2:
                        Console.Clear();
                        if (!(resultOfTheSum.PreviousAccountSafekeeping.Count == 0))
                        {
                            Console.WriteLine("Outcome of the questions (SUM): ");
                            for (int i = 0; i < resultOfTheSum.PreviousAccountSafekeeping.Count; i++)
                            {
                                Console.WriteLine($"{i}: {resultOfTheSum.PreviousAccountSafekeeping[i]}");
                            }
                        }
                        else
                            Console.WriteLine("Não há registros de resultados");
                        break;

                    case 3:
                        Console.WriteLine();
                        for (int i = 0; i < 5; i++)
                        {
                            int numberOne = random.Next(1, 100);
                            int numberTwo = random.Next(1, 100);
                            Console.Write($"{numberOne}-{numberTwo}: ");

                            if (int.TryParse(Console.ReadLine(), out int result))
                            {
                                if (result == Operations.Subtraction(numberOne, numberTwo))
                                    resultOfTheSubtraction.Corrects += 1;
                                else
                                    resultOfTheSubtraction.Erros += 1;

                                resultOfTheSubtraction.PreviousAccountSafekeeping.Add($"{numberOne} - {numberTwo}: {result}");
                            }
                            else
                                Console.WriteLine("Invalid input");
                        }
                        Console.WriteLine($"Result subtração:\nCorrect: {resultOfTheSubtraction.Corrects}\nErrors: {resultOfTheSubtraction.Erros}");
                        break;
                    case 4:
                        Console.Clear();
                        if (!(resultOfTheSubtraction.PreviousAccountSafekeeping.Count == 0))
                        {
                            Console.WriteLine("Outcome of the questions (SUBTRACT): ");
                            for (int i = 0; i < resultOfTheSubtraction.PreviousAccountSafekeeping.Count; i++)
                            {
                                Console.WriteLine($"{i}: {resultOfTheSubtraction.PreviousAccountSafekeeping[i]}");
                            }

                        }

                        else
                            Console.WriteLine("Não há registros de resultados");
                        break;
                    case 5:
                        Console.WriteLine();
                        for (int i = 0; i < 5; i++)
                        {
                            int numberOne = random.Next(1, 100);
                            int numberTwo = random.Next(1, 100);
                            Console.WriteLine($"{numberOne} x {numberTwo}: ");

                            if (int.TryParse(Console.ReadLine(), out int result))
                            {
                                if (result == Operations.Multiplication(numberOne, numberTwo))
                                    resultOfTheMultiplication.Corrects += 1;
                                else
                                    resultOfTheMultiplication.Erros += 1;

                                resultOfTheMultiplication.PreviousAccountSafekeeping.Add($"{numberOne} x {numberTwo}: {result}");
                            }
                            else
                                Console.WriteLine("Invalid input");
                        }
                        Console.WriteLine($"Result multiplication:\nCorrect: {resultOfTheMultiplication.Corrects}\nErrors: {resultOfTheMultiplication.Erros}");
                        break;
                    case 6:
                        Console.Clear();
                        if (!(resultOfTheMultiplication.PreviousAccountSafekeeping.Count == 0))
                        {
                            Console.WriteLine("Outcome of the question (MULTIPLICATION)");
                            for (int i = 0; i < resultOfTheMultiplication.PreviousAccountSafekeeping.Count; i++)
                            {
                                Console.WriteLine($"{i}: {resultOfTheMultiplication.PreviousAccountSafekeeping[i]}");
                            }
                        }
                        else
                            Console.WriteLine("Não há registros de resultados");
                        break;
                    case 7:
                        Console.WriteLine();
                        for (int i = 0; i < 5; i++)
                        {
                            int numberOne, numberTwo;
                            do
                            {
                                numberOne = random.Next(1, 100);
                                numberTwo = random.Next(1, 100);
                            }
                            while (numberOne % numberTwo != 0);
                            Console.WriteLine($"{numberOne} / {numberTwo}: ");
                            if (int.TryParse(Console.ReadLine(), out int result))
                            {
                                if (result == Operations.Division(numberOne, numberTwo))
                                    resultOfTheDivision.Corrects += 1;
                                else
                                    resultOfTheDivision.Erros += 1;

                                resultOfTheDivision.PreviousAccountSafekeeping.Add($"{numberOne} / {numberTwo}: {result}");
                            }
                            else
                                Console.WriteLine("Invalid input");
                        }
                        Console.WriteLine($"Result division:\nCorrect: {resultOfTheDivision.Corrects}\nErrors: {resultOfTheDivision.Erros}");
                        break;
                    case 8:
                        Console.Clear();
                        if (!(resultOfTheDivision.PreviousAccountSafekeeping.Count == 0))
                        {
                            Console.WriteLine("Outcome of the question (DIVISION)");
                            for (int i = 0; i < resultOfTheDivision.PreviousAccountSafekeeping.Count; i++)
                            {
                                Console.WriteLine($"{i}: {resultOfTheDivision.PreviousAccountSafekeeping[i]}");
                            }
                        }
                        else
                            Console.WriteLine("Não há registros de resultados");
                        break;
                    default:
                        if (validationExit != 0)
                            Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
            while (validationExit != 0);
        }

        public static void Painel()
        {
            Console.Clear();

            Console.WriteLine("=========== CALCULATOR ===========");
            Console.WriteLine();

            Console.WriteLine("Select an option:");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine(" 1 - Addition");
            Console.WriteLine(" 2 - Addition history");

            Console.WriteLine(" 3 - Subtraction");
            Console.WriteLine(" 4 - Subtraction history");

            Console.WriteLine(" 5 - Multiplication");
            Console.WriteLine(" 6 - Multiplication history");

            Console.WriteLine(" 7 - Division");
            Console.WriteLine(" 8 - Division history");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 0 - Exit");
            Console.WriteLine();
        }

        
    }
}