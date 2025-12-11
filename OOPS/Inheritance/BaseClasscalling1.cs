using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPS.Inheritance
{
    internal class BaseClasscalling1
    {
        public BaseClasscalling1(){
            Console.WriteLine("Parent Constructor");
        }
        public BaseClasscalling1(int x) {
            Console.WriteLine($"Parent Constructor called : {x}");
        }
    }
    internal class BaseClasscalling2 : BaseClasscalling1 {
        public BaseClasscalling2() : base(10){
            
            Console.WriteLine("Child Constructor called :");
        }
    }
}
// parent constructor is called automatically if it is parameter less