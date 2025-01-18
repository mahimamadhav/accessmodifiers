using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accessmodifiers;


namespace project2
{
    internal class Program:accessmodifiers.Program  // other assembly with inheritance
    {
        static void Main(string[] args)
        {
            Program p = new Program();
           
            p.protectedinternalmethod();
            p.protectedmethod();
            p.publicmethod();
            
           
        }
    }
}
