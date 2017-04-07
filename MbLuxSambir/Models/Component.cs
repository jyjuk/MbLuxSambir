using System;

namespace MbLuxSambir.Models
{
    public class Component
    {
        private float _count;

        public Component(string name, float count)
        {
            Name = name;
            Count = count;
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

        //public int Size { get; set; }
    }
}