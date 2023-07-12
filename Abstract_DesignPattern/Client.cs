using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_DesignPattern
{
    //this class will use AbstractFactory & abstractProduct interface to create a family of related obj
    class Client
    {
        private readonly Shirt shirt;
        private readonly Trousers trousers;

        //Constructor
        public Client(ClothesFactory factory)
        {
            shirt = factory.CreateShirt();
            trousers = factory.CreateTrousers();
        }
        public string DescribeYourClothes()
        {
            return $"Today I'm dressed in : {shirt.GetType().Name} and {trousers.GetType().Name}";
        }
    }
}
