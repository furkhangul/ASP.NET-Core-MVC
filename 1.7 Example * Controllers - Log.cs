using Basic.Models;


namespace Basic.Controllers
{
    public static class Log
    {
        private static List<Data> Users = new();
        public static IEnumerable<Data> Register() => Users;

        public static bool Add(Data user)
        {
            if (Users.Any(u => u.Email.Equals(user.Email, StringComparison.CurrentCultureIgnoreCase)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }

}
