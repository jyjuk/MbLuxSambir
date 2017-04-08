using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MbLuxSambir.Models;
using MbLuxSambir.BusinessLogic;

namespace MbLuxSambir.ViewModels
{
   public class ConfiguratorViewModel
    {
        public ObservableCollection<Component> Pricess { get; set; }
    }
}
