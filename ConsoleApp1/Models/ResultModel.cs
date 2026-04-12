using System.Security.Principal;

namespace ConsoleApp1.Models
{
    public class ResultModel
    {
        public int Id { get; set; }
        public int Corrects { get; set; }
        public int Erros { get; set; }
        public List<string> PreviousAccountSafekeeping { get; set; } = new List<string>();
    }
}
