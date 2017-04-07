using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbLuxSambir.Models
{
    public class FurnituraPlus : Tumbochka
    {
        public FurnituraPlus(string name)
        {
            Name = name;
            Components = new List<Component>
            {
               new Component("Плита", 0.5f),
               new Component("Конфірмат", 12),
               new Component("DVP", 0.2f),
               new Component("Ручка", 1),
               new Component("PCV", 2),
               new Component("Шурупи", 20),
               new Component("Фасад", 1)
             };


        }

    }
}
