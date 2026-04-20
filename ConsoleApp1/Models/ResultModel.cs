using System.Security.Principal;

namespace ConsoleApp1.Models
{
    public class ResultModel
    {
        public int Successes { get; set; }
        public int Errors { get; set; }
        public List<string> ListOfAnswers { get; set; } = new List<string>();


        public static void ShowResult(ResultModel modelShow)
        {
            if (modelShow.ListOfAnswers.Count == 0)
                Console.WriteLine("Não há registros");
            else
            {
                for (int i = 0; i < modelShow.ListOfAnswers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}º: {modelShow.ListOfAnswers[i]}");
                }
            }
        }

        public override string ToString()
        {
            return $"Corrects: {Successes}, Errors: {Errors}, Previous Accounts: {string.Join(", ", ListOfAnswers)}";
        }
    }
}
