using Abstract_DesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_DesignPattern.Factories
{
    //Concrete factory 1

    //Interface/Abstract class ko inherit krke ---- unke abstarct method ko define krta hai
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }
        public override Trousers CreateTrousers()
        {
            return new Jeans();  
        }
    }
}
