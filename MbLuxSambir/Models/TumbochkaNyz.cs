using System.Collections.Generic;

namespace MbLuxSambir.Models
{
    public class TumbochkaNyz : Tumbochka
    {
        public TumbochkaNyz(string name)
        {
            Name = name;
            Components = new List<Component>
            {
                new Component("Pluta", 0.5f),
                new Component("Confrimator", 12),
                new Component("DVP", 0.2f),
                new Component("Petli", 2),
                new Component("Rychka", 1),
                new Component("Stilnycya", 1),
                new Component("Noga", 4),
                new Component("PCV", 2),
                new Component("bolts", 20),
                new Component("Doors", 1)
            };
        }

    }
}