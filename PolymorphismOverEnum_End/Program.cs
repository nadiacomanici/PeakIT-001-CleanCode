using PolymorphismOverEnum_End.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverEnum_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Student nadia = new DailyStudent("Nadia", "Comanici");
            Student ionel = new EveningStudent("Ionel", "Ionescu");
            Student maria = new WeekendStudent("Maria", "Popescu");

            Console.WriteLine($"{nadia.FirstName} are nevoie de {nadia.GetMinimumCreditPointsToPromote()} credite.");
            Console.WriteLine($"{ionel.FirstName} are nevoie de {ionel.GetMinimumCreditPointsToPromote()} credite.");
            Console.WriteLine($"{maria.FirstName} are nevoie de {maria.GetMinimumCreditPointsToPromote()} credite.");
        }
    }
}
