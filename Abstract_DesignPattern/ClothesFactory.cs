using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_DesignPattern
{
    //Abstract Factory Interface
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();
    }

    
}
