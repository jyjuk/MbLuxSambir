using System;

namespace MbLuxSambir.Models
{
    public class Component
    {
        private float _count;
        private double _price;

        //public Component()
        //{

        //}

        public Component(string name, float count)
        {
            Name = name;
            Count = count;
        }

        public Component(double price, string name)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public float Count
        {
            get { return _count; }
            set
            {
                if (value >= 0)
                    _count = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
            }
        }
    }
}