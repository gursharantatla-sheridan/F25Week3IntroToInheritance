namespace F25Week3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass();
            //objBase.myPublicVar = 1;

            DerivedClass objDerived = new DerivedClass("hello", "world");
            //objDerived.myPublicVar = 2;
        }
    }
}
