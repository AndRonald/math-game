using ConsoleApp1.Models;
using System;

namespace ConsoleApp1.Entities
{
    public class Quiz
    {
        public static Random random { get; set; } = new Random();
        public static void QuizSoma(ResultModel modelSum) 
        {
            for (int i = 1; i < 6; i++)
            {
                int firstNumber = random.Next(1, 100);
                int secondNumber = random.Next(1, 100);
                Console.Write($"{i}º) {firstNumber}+{secondNumber}= ");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == Operations.Addition(firstNumber, secondNumber))
                        modelSum.Successes += 1;
                    else
                        modelSum.Errors += 1;

                    modelSum.ListOfAnswers.Add($"{firstNumber} + {secondNumber}: {result}");
                }
                else
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"\nCorrect: {modelSum.Successes}\nErrors: {modelSum.Errors}\n");
        }

        public static void QuizSubtraction(ResultModel modelSubtraction)
        {
            for (int i = 1; i < 6; i++)
            {
                int firstNumber = random.Next(1, 100);
                int secondNumber = random.Next(1, 100);
                Console.Write($"{i}º) {firstNumber}-{secondNumber}= ");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == Operations.Subtraction(firstNumber, secondNumber))
                        modelSubtraction.Successes += 1;
                    else
                        modelSubtraction.Errors += 1;

                    modelSubtraction.ListOfAnswers.Add($"{firstNumber} - {secondNumber}: {result}");
                }
                else
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"\nCorrect: {modelSubtraction.Successes}\nErrors: {modelSubtraction.Errors}\n");
        }

        public static void QuizMultiplication(ResultModel modelMultiplication)
        {
            for (int i = 1; i < 6; i++)
            {
                int firstNumber = random.Next(1, 100);
                int secondNumber = random.Next(1, 100);
                Console.Write($"{i}º) {firstNumber}*{secondNumber}= ");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == Operations.Multiplication(firstNumber, secondNumber))
                        modelMultiplication.Successes += 1;
                    else
                        modelMultiplication.Errors += 1;

                    modelMultiplication.ListOfAnswers.Add($"{firstNumber} * {secondNumber}: {result}");
                }
                else
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"\nCorrect: {modelMultiplication.Successes}\nErrors: {modelMultiplication.Errors}\n");
        }

        public static void QuizDivision(ResultModel modelDivision)
        {
            for (int i = 1; i < 6; i++)
            {
                int numberOne, numberTwo;
                do
                {
                    numberOne = random.Next(1, 100);
                    numberTwo = random.Next(1, 100);
                }
                while (numberOne % numberTwo != 0);
                Console.Write($"{i}º) {numberOne} / {numberTwo}= ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == Operations.Division(numberOne, numberTwo))
                        modelDivision.Successes += 1;
                    else
                        modelDivision.Errors += 1;

                    modelDivision.ListOfAnswers.Add($"{numberOne} / {numberTwo}: {result}");
                }
                else
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"\nCorrect: {modelDivision.Successes}\nErrors: {modelDivision.Errors}\n");
        }
    }
}
