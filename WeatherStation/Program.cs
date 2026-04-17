using Database;
using Repozitory;

namespace WeatherStation
{

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var myContext = new MyApplycationContekst())
            {
                myContext.Database.EnsureCreated();
                IUserRepository user = new UserRepository(myContext);
                
                var randomUserId = Random.Shared.Next(1000) + 1;
                var randomUser = userRepository.GetUser(randomUserId);
            }

            Console.WriteLine("Dwa");
        }
    }
}

