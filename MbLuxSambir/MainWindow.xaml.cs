using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MbLuxSambir.Models;
using MbLuxSambir.ViewModels;

namespace MbLuxSambir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TumbochkaVerh verkh;
        TumbochkaNyz nyz;

        FurnituraPlus fp ;

        public MainWindow()
        {
            InitializeComponent();

            var mainViewModel = new MainViewModel();

            mainViewModel.TumbochkaNyzes = new ObservableCollection<TumbochkaNyz>();
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Кутова"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Плита"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Шуфляди"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 150"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 200"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 250"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 300"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 350"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 400"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 450"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 500"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 550"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 600"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 650"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 700"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 750"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 800"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 850"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 900"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 950"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("нижній 1000"));


            mainViewModel.TumbochkaVerkhs = new ObservableCollection<TumbochkaVerh>();
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Кутова"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 150"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 200"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 250"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 300"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 350"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 400"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 450"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 500"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 550"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 600"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 650"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 700"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 750"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 800"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 850"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("Верхній 900"));


            mainViewModel.Furnitura = new ObservableCollection<FurnituraPlus>();
            mainViewModel.Furnitura.Add(new FurnituraPlus("Cargo"));
            mainViewModel.Furnitura.Add(new FurnituraPlus("Сушка"));
            mainViewModel.Furnitura.Add(new FurnituraPlus("Вмонтована Витяжка"));

            DataContext = mainViewModel;


        }

       


        public static int ChekInt(string s)
        {
            int i;
            try
            {
                i = Int32.Parse(s);
                return i;
            }
            catch (FormatException)
            {
                i = -3;
                return i;
            }

        }

        private void btnConfigurator_Click(object sender, RoutedEventArgs e)
        {
            Configurator cf = new Configurator();
            cf.Width = this.Width;
            cf.Height = this.Height;
            cf.Left = this.Left;
            cf.Top = this.Top;
            this.Close();
            cf.Show();
        }

        private void btnFactura_Click(object sender, RoutedEventArgs e)
        {

        }
        private double TopPrice()
        {
            return (double)verkh.Price;
        }

        private double BottomPrice()
        {
            return (double)nyz.Price;
        }

        private double FurniturePlus()
        {

            return (double)fp.Price;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double price = TopPrice() + BottomPrice() + FurniturePlus();
            MessageBox.Show((price).ToString());
        }
    }
}
