using System.Collections.Generic;
using MbLuxSambir.BusinessLogic;

namespace MbLuxSambir.Models
{
    public class Tumbochka
    {
        readonly PriceInfo _priceInfo;

        public Tumbochka() //we have to use Dependency injection here
        {
            _priceInfo = new PriceInfo();
        }

        public string Name { get; set; }

        public List<Component> Components { get; set; }

        public int Count
        {
            get { return 9; }
        }

        public decimal Price
        {
            get
            {
                decimal resultPrice = 0;
                foreach (var component in Components)
                {
                    resultPrice += _priceInfo.GetPrice(component.Name) * (decimal)component.Count;
                }

                return resultPrice;
            }
        }
    }
}