using System.Collections.Generic;

namespace MbLuxSambir.BusinessLogic
{
    public class PriceInfo
    {
        public decimal GetPrice(string componentName)
        {
            return 9;
        }

        public Dictionary<string, decimal> GetAll()
        {
            var dictionary = new Dictionary<string, decimal>()
            {
                {"Плита", 150 },
                {"DVP ",200 },
                {"Нога кухонна",5 },
                {"Шурупи",0.1m },
                {"Конфірмат",2 },
                {"Полко тримач",0.5m },
                {"Стяжка міжсекційна",0.5m },
                {"Фасад",540 },
                {"Ручка",15 },
                {"Ручка2",21 },
                {"Завіс",3 },
                {"Завіс дотяг",25 },
                {"Направляюча",37 },
                {"Стільниця",120 },
                {"PCV",7 },
                {"Клей PCV",30 },
                {"Cargo",140 },
                {"Карніз",27 },
                {"Ліфт",10 },
                {"Сушка",70 },
                {"Петлі монтажні",0.5m }
            };
            return dictionary;
        }
    }
}

