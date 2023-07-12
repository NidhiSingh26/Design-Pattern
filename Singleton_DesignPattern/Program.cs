using System;

namespace Singleton_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            s1.someBusinessLogic();
            Console.ReadLine();
        }
    }
}
