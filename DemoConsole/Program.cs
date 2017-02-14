using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = "xyzcom\\design.department,xyzcom\\basil.jad,xyzcom\\aloshi.alex, xyzcom\\michel felx,xyzcom\\karim.hal,xyzcom\\shah shaan "; ;
            string val = "xyzcom\\design.department";
            if (person.Any(val.Contains))
            {
                Console.WriteLine("Success");
            }

        }
    }
}
