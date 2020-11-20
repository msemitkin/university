namespace Solid_4
{
    class Outerwear : ISellable, IItemWithDiscount, IItemWithPromocode, IItemWithSize, IItemWithColor
    {
        public void ApplyDiscount(string discount) { }

        public void ApplyPromocode(string promocode) { }

        public void SetColor(byte color) { }

        public void SetPrice(double price) { }

        public void SetSize(byte size) { }
    }
}
