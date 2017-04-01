using System.Collections.Generic;

namespace MbLuxSambir.Models
{
    public class TumbochkaVerh : Tumbochka
    {

        public TumbochkaVerh(string name)
        {
            Name = name;
            Components = new List<Component>
            {
                new Component("Pluta", 0.5f),
                new Component("Confrimator", 12),
                new Component("DVP", 0.2f),
                new Component("Petli", 2),
                new Component("Rychka", 1),
                new Component("PCV", 2),
                new Component("bolts", 20),
                new Component("Doors", 1),
                new Component("Vukho", 2),
                new Component("Karniz", 1)
            };
        }
    }
}