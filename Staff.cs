using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyRestaurant
{
    class Staff
    {
        public string name;
        public int salary;
        int howmany;
        public void FullStaff()
        {

            Console.WriteLine("Number of personnel?");
            howmany = int.Parse(Console.ReadLine());


            for (int i = 0; i < howmany; i++)
            {
                Console.WriteLine(("Type the name of your staff:"));
                name = Console.ReadLine();

                Console.WriteLine("Type salary:");
                salary = int.Parse(Console.ReadLine());

            }


        }

        public void WholeStaff()
             {
                    for (int i=0;i<howmany; i++)
                    Console.WriteLine("Name of your staff {0} and salary {1}", name, salary);
            }
        

        
    }
}

        
   
            

    

  
