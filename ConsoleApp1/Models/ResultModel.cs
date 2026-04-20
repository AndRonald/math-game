using System.Security.Principal;

namespace ConsoleApp1.Models
{
    public class ResultModel
    {
        public int Successes { get; set; }
        public int Errors { get; set; }
        public List<string> ListOfAnswers { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Corrects: {Successes}, Errors: {Errors}, Previous Accounts: {string.Join(", ", ListOfAnswers)}";
        }
    }
}
