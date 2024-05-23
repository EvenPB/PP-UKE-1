using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_UKE_1
{
    public class Deltaker
    {
        public string Name  { get; set; }

        public int Age  { get; set; } 
        public string Haircolor { get; set; }
        public string Hobby { get; set; }

        public Deltaker(string name, int age, string haircolor, string hobby)
        {
            Name = name;
            Age = age;
            Haircolor = haircolor;
            Hobby = hobby;

        }

        public Deltaker()
        {
            
        }
        public void PrintDeltaker()
        {
            Console.WriteLine($"Hey, im {Name}! I'm {Age} Years old and my favorite hobby is {Hobby}");
        }
    }
    

}
