using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_UKE_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var D1 = new Deltaker
            {
                Name = "Kalle",
                Age = 22,
                Haircolor = "Dark blonde",
                Hobby = "Fishing"
            };
            
            
            D1.PrintDeltaker();

            var D2 = new Deltaker("Bjarne", 48, "bald", "mechanic");
           
            D2.PrintDeltaker();
        }
        
    }

}
