using System.Collections.Generic;

namespace MbLuxSambir.BusinessLogic
{
    public class PriceInfo
    {
        public decimal GetPrice(string componentName)
        {
            return 6;
        }

        public Dictionary<string, decimal> GetAll()
        {
            var dictionary = new Dictionary<string, decimal>() { { "name", 90 } };
            return dictionary;
        }
    }
}
