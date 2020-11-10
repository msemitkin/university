namespace XmlParser
{
    public class Bike
    {
        string brand;
        string size;
        string material;
        string colour;
        int travel;
        double wheelSize;
        double weight;
        double price;

        public Bike()
        {
        }

        public Bike(string brand, string size, string material, string colour,
            int travel, double wheelSize, double weight, double price)
        {
            this.brand = brand;
            this.size = size;
            this.material = material;
            this.colour = colour;
            this.travel = travel;
            this.wheelSize = wheelSize;
            this.weight = weight;
            this.price = price;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Size { get => size; set => size = value; }
        public string Material { get => material; set => material = value; }
        public string Colour { get => colour; set => colour = value; }
        public int Travel { get => travel; set => travel = value; }
        public double WheelSize { get => wheelSize; set => wheelSize = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Price { get => price; set => price = value; }

        public bool SatisfyFilter(Bike filter)
        {
            return (price <= filter.price || filter.price == 0)
                && (brand == filter.brand || filter.brand == "")
                && (size.Equals(filter.size) || filter.size == "")
                && (material == filter.material || filter.material == "")
                && (colour == filter.colour || filter.colour == "")
                && (travel == filter.travel || filter.travel == 0)
                && (wheelSize == filter.wheelSize || filter.wheelSize == 0)
                && (weight == filter.weight || filter.weight == 0);
        }
    }
}
