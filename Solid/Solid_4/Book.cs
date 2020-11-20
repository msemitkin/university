namespace Solid_4
{
    class Book : ISellable, IItemWithDiscount
    {
        public void ApplyDiscount(string discount) { }

        public void SetPrice(double price) { }
    }
}
