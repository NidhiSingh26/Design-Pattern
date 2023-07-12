using Abstract_DesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_DesignPattern.Factories
{
    //Concrete Factory 2
    class ElegantClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();

        }
        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}
