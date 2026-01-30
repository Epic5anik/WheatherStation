using Database;

namespace WeatherStation
{

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var myContext = new MyApplycationContekst())
            {
                myContext.Database.EnsureCreated();
            }

            Console.WriteLine("Dwa");
        }
    }
}

