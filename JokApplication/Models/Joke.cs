using System.Net.NetworkInformation;

namespace JokApplication.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public Joke()
        {
            
        }

    }
}
