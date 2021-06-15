using System;
using System.IO;
using System.Text;

namespace MyRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Staff mystaff = new Staff();
            mystaff.FullStaff();

            
        //Egentligen så hade jag velat ha denna kod som sedan i methoden WholeStff() på något sätt lopade runt
        //antal anställda och lön. Nåväl, provade lite fram o tillbaks. 

         //Svar 1: De anställda o säkert löner också men jag valde att baka ihop dem.
         //Svar 2. Ville egentligen bara ha 1st method som skrev ut alla anställda. Men men...

            //Console.WriteLine("Number of personnel?");
            //howmany = int.Parse(Console.ReadLine());

            //for (int i = 0; i < howmany; i++)
            //{
            //    Console.WriteLine(("Type the name of your staff:"));
            //    mystaff.name = Console.ReadLine();

            //    Console.WriteLine("Type salary:");
            //    mystaff.salary = int.Parse(Console.ReadLine());

            //}

            mystaff.WholeStaff();
            
            





        }
    }
}
