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
    }

    public class DerivedClass : BaseClass
    {
        public void myMethod()
        {
            //myPrivateVar = 101;
            myProtectedVar = 102;
            myPublicVar = 103;
        }
    }
}
