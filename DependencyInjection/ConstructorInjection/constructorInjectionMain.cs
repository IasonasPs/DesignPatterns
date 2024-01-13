namespace DependencyInjection.ConstructorInjection
{
    public class constructorInjectionMain()
    {
        public static void ctorInjectionMain()
        {
            ConstructorInjection ci = new ConstructorInjection(new Format("this is my text for the Print method"));
            ci.print();
            Console.ReadKey();
        }
    }
}