using Abstract_DesignPattern.Factories;
using System;

namespace Abstract_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client BussinessMan = new Client(new ElegantClothesFactory());
            Console.WriteLine($"BussinessMan : {BussinessMan.DescribeYourClothes()}");

            Client Student = new Client(new CasualClothesFactory());
            Console.WriteLine($"Student : {Student.DescribeYourClothes()}");

            Console.ReadKey();


        }
    }
}


/*
 

                              Client (Description method hai )
                             /                          
              Clothes Factory
             /              \
Casual Clothes        Elegant Clothes 
Factory                 Factory
    |                       |
Abstract Method             Abstract Method 
of Shirt & Trouser          of Shirt & Trouser





                    Trousers                             Shirt
                    /       \                           /      \
               Jeans       SuitTrouser           DressShirt    PoloShirt

*/