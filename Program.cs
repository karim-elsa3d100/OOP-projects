using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudyCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1001, "Saleh Saad", 180, 10);
            Maintenance maintenance = new Maintenance(1002, "Ahmed Saad", 182, 8);
            Sales saler = new Sales(1003, "Mohamed Saad", 176, 9, 0.05m, 10_000m);
            Developer developer = new Developer(1004, "Karim Saad", 180, 14, true );

            Employee[] employeer =  { manager, maintenance, saler, developer };
            foreach( Employee employee in employeer ) 
            {
                Console.WriteLine( employee );
            }
            Console.ReadKey();
        }

    }
 
   
}

