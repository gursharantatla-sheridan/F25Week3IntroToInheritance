using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F25Week3IntroToInheritance
{
    public class BaseClass
    {
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;

        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }

        public BaseClass(string msg)
        {
            Console.WriteLine("Base class constructor with message: " + msg);
        }
    }

    public class DerivedClass : BaseClass
    {

        public DerivedClass()
        {
            Console.WriteLine("Derived class constructor called");
        }

        public DerivedClass(string msg1, string msg2) : base(msg1)
        {
            Console.WriteLine("Derived class constructor with message: " + msg2);
        }


        public void myMethod()
        {
            //myPrivateVar = 101;
            myProtectedVar = 102;
            myPublicVar = 103;
        }
    }
}
