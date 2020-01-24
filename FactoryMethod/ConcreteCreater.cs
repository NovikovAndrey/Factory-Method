namespace FactoryMethod
{
    internal class ConcreteCreater : Creater
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}