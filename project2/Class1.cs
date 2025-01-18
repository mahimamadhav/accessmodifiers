using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Class1      //other assembly witout inheritance
    {
        static void Main(string[] args)
        {
            accessmodifiers.Program p = new accessmodifiers.Program();
            p.publicmethod();
            Console.ReadLine(  );
        }
    }
}
