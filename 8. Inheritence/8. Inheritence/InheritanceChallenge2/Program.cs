using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 40000);

            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norirs", "Chuck", 9999999);
            chuckNorris.Lead();

            Trainee ann = new Trainee(32, 8, "Gartner", "Ann", 10000);
            ann.Learn();
            ann.Work();

            Console.ReadKey();
        }
    }
}
