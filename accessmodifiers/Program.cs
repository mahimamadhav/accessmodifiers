using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
   public class Program   //declared class
    {              
        //consuming withing the same class within same assembly accessmodifiers
   
        public void publicmethod()
        {
            Console.WriteLine("hi from public method");
        }
        private void privatemethod()
        {
            Console.WriteLine("hi from private method");
        }
        protected void protectedmethod()
        {
            Console.WriteLine("hi from protected method");
        }
        protected internal void protectedinternalmethod()
        {
            Console.WriteLine("hi from protected internal  method");
        }
        private protected void privateprotectedmethod()
        {
            Console.WriteLine("hi from private protected method");
        }
        internal void internalmethod()
        {
            Console.WriteLine("hi from internal  method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();//creating object
           
            p.publicmethod();
            p.internalmethod();
            p.protectedmethod();
            p.privatemethod();
            p.protectedinternalmethod();
            p.privateprotectedmethod();
            Console.ReadLine();
        }
        


    }
}
