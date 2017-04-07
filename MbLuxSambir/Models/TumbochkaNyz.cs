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
                new Component("Плита", 0.5f),
                new Component("Конфірмат", 12),
                new Component("DVP", 0.2f),
                new Component("Петла", 2),
                new Component("Ручка", 1),
                new Component("Стільниця", 1),
                new Component("Нога кухонна", 4),
                new Component("PCV", 2),
                new Component("Шурупи", 20),
                new Component("Фасад", 1)
            };
        }

    }
}