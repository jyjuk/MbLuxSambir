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
                new Component("Плита", 0.5f),
                new Component("Конфірмат", 12),
                new Component("DVP", 0.2f),
                new Component("Петлі", 2),
                new Component("Ручка", 1),
                new Component("PCV", 2),
                new Component("Шурупи", 20),

                new Component("Фасад", 1),
                new Component("Вухо монтажне", 2),
                new Component("Карніз", 1)
            };
        }
    }
}