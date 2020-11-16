namespace XmlParser
{
    public class Bike
    {

        public Bike()
        {
        }

        public Bike(string brand, string size, string material, string colour,
            int travel, double wheelSize, double weight, double price)
        {
            this.Brand = brand;
            this.Size = size;
            this.Material = material;
            this.Colour = colour;
            this.Travel = travel;
            this.WheelSize = wheelSize;
            this.Weight = weight;
            this.Price = price;
        }

        public string Brand { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Colour { get; set; }
        public int Travel { get; set; }
        public double WheelSize { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand}\n"
                + $"Size: {Size}\n"
                + $"Material: {Material}\n"
                + $"Colour: {Colour}\n"
                + $"Travel: {Travel}\n"
                + $"Wheelsize: {WheelSize}\n"
                + "~~~~~~~~~~~~~~~~~~~~~~~~~\n";
        }
    }
}
