using System;

namespace FactoryMethod
{
    abstract class Creater
    {
        Product product;
        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }

    }
}