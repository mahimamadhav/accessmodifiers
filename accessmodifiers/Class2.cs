using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    internal class Class2
    {
        //same assembly and class without inheritance
        static void Main(string[] args)
        {
            
            Program p = new Program(); //parent class
            
            p.publicmethod();
           // p.privatemethod();
          // p.protectedmethod();
            p.protectedinternalmethod();
            p.internalmethod();
            Console.ReadLine();

                
        }
    }
}
