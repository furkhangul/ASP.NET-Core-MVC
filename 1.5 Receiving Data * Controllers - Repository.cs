using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public static class Repostory 
    {
        private static List<Candidate> App = new();
        public static IEnumerable<Candidate> Application => App;

        public static void Add(Candidate candidate)
        {
            App.Add(candidate);
        }
    }
}
