using System.Collections.ObjectModel;
using MbLuxSambir.Models;

namespace MbLuxSambir.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<TumbochkaNyz> TumbochkaNyzes { get; set; }
        public ObservableCollection<TumbochkaVerh> TumbochkaVerkhs { get; set; }
        public ObservableCollection<Tumbochka> Tumbochkas { get; set; }

        public ObservableCollection<FurnituraPlus> Furnitura { get; set; }
    }
}
