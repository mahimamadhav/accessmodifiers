using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    internal class Class1:Program//child class
    {
        //consuming from child class
        //same assembly and class with inheritance
        static void Main(string[] args)
        {
            Class1 p = new Class1();
            
            p.publicmethod();
            //p.privatemethod();
            p.privateprotectedmethod();
            p.internalmethod();
            p.protectedmethod();
            p.protectedinternalmethod();
            Console.ReadLine(  );
        }
    }
}
