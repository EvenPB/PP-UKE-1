using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_UKE_1
{
    public class Program
    {
         static void Main(string[] args)
        {

            CheckInput();



            
        }


       static void CheckInput()
        {
            while (true)
            {
                
                Console.WriteLine("Choice 1 Kalle");
                Console.WriteLine("Choice 2 Bjarne");
                Console.WriteLine("Choice 3 Nils");

                string userChoice = Console.ReadLine();

                var D1 = new Deltaker("Kalle", 22, "Dark Blond", "Fishing");

                var D2 = new Deltaker("Bjarne", 48, "Bald", "mechanic");

                var D3 = new Deltaker("Nils", 69, "Gray", "Shooting");

                switch (userChoice)
                {
                    case "1":
                        D1.PrintDeltaker();
                        break;

                    case "2":
                        D2.PrintDeltaker();
                        break;

                    case "3":
                        D3.PrintDeltaker();
                        break;
                    case "0":
                        return;

                    default:
                        Console.WriteLine("unassigned choice");
                            break;
                }
            }
        }
    }

}
