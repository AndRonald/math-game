using System;
using ConsoleApp1.Models;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sum = new ResultModel();
            var subtraction = new ResultModel();
            var multiplication = new ResultModel();
            var division = new ResultModel();

            int validationExit = 1;
            do
            {
                Painel();
                if (!(int.TryParse(Console.ReadLine(), out validationExit)))
                    validationExit = 10;

                switch (validationExit)
                {
                    case 1:
                        Quiz.QuizSoma(sum);
                        break;

                    case 2:
                        ResultModel.ShowResult(sum);
                        break;

                    case 3:
                        Quiz.QuizSubtraction(subtraction);
                        break;
                    case 4:
                        ResultModel.ShowResult(subtraction);
                        break;
                    case 5:
                        Quiz.QuizMultiplication(multiplication);
                        break;
                    case 6:
                        ResultModel.ShowResult(multiplication);
                        break;
                    case 7:
                        Quiz.QuizDivision(division);
                        break;
                    case 8:
                        ResultModel.ShowResult(division);
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