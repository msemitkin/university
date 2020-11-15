using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace XmlParser
{
    public class BikeFilter : Bike
    {
        public bool satistyFilter(XElement element)
        {
            Bike bike = new Bike();
            bike.Brand = element.Attribute("brand").Value;
            bike.Colour = element.Attribute("colour").Value;
            bike.Material = element.Attribute("material").Value;
            bike.Size = element.Attribute("size").Value;
            bike.Travel = Int32.Parse(element.Attribute("travel").Value);
            bike.WheelSize = double.Parse(element.Attribute("wheelsize").Value);
            return satisfyFilter(bike);
        }

        public bool satisfyFilter(Bike bike)
        {

            return satisfyBrand(bike.Brand)
                    && satisfyColour(bike.Colour)
                    && satisfyMaterial(bike.Material)
                    && satisfySize(bike.Size)
                    && satisfyTravel(bike.Travel)
                    && satisfyWheelSize(bike.WheelSize);
        }

        private bool satisfyBrand(string bikeBrand)
        {
            return Brand == "" || Brand == bikeBrand;
        }

        private bool satisfySize(string bikeSize)
        {
            return Size == "" || Size == bikeSize;
        }

        private bool satisfyColour(string bikeColour)
        {
            return Colour == "" || Colour == bikeColour;
        }

        private bool satisfyMaterial(string bikeMaterial)
        {
            return Material == "" || Material == bikeMaterial;
        }

        private bool satisfyWheelSize(double bikeWheelSize)
        {
            return WheelSize == 0 || WheelSize == bikeWheelSize;
        }

        private bool satisfyTravel(int bikeTravel)
        {
            return Travel == 0 || Travel == bikeTravel;
        }
    }
}
