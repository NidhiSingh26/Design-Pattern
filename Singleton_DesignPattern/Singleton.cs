using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_DesignPattern
{
    //class will be sealed so that it can't be inherited through external class
    public sealed class Singleton
    {
        //const private to prevent direct construction calls with the `new` operator.
        private Singleton() {}
        public static Singleton instance = null;

        public static Singleton GetInstance()
        {
            {
                if(instance == null)
                {
                    return new Singleton();
                }
            }
            return instance;
        }
        public void someBusinessLogic()
        {
            Console.WriteLine("This is Some Business Logic implementing here....");
        }
    }
}
