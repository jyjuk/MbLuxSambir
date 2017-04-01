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

        FurnituraPlus fp = new FurnituraPlus();

        public MainWindow()
        {
            InitializeComponent();

            var mainViewModel = new MainViewModel();

            mainViewModel.TumbochkaNyzes = new ObservableCollection<TumbochkaNyz>();
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Кутова"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Кутова15"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Кутова25"));
            mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Кутова35"));


            mainViewModel.TumbochkaVerkhs = new ObservableCollection<TumbochkaVerh>();
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова15"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова25"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова35")); mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова15"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова25"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова35")); mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова15"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова25"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова35")); mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова15"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова25"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова35")); mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова15"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова25"));
            mainViewModel.TumbochkaVerkhs.Add(new TumbochkaVerh("-=Кутова35"));

            DataContext = mainViewModel;

            SetLabelCol1();
            SetLabelCol2();
            SetLabelCol3();

        }

        private void SetLabelCol1()
        {
            //VKut.label.Content = "Верхній кутовий";
            //V15.label.Content = "Верхній 15";
            //V30.label.Content = "Верхній 30";
            //V40.label.Content = "Верхній 40";
            //V45.label.Content = "Верхній 45";
            //V60.label.Content = "Верхній 60";
            //VVut.label.Content = "Верхній Витяжка";
        }

        private void SetLabelCol2()
        {
            //NKut.label.Content = "Нижній кутовий";
            //N15.label.Content = "Нижній 15";
            //N30.label.Content = "Нижній 30";
            //N40.label.Content = "Нижній 40";
            //N45.label.Content = "Нижній 45";
            //N60.label.Content = "Нижній 60";
            //NKargo.label.Content = "Cargo";
            //NSushka.label.Content = "Сушка";
            //NPlyta.label.Content = "Плита";
            //NShuflada.label.Content = "Шуфляди";
        }

        private void SetLabelCol3()
        {
            //FpDot.label.Content = "Завіс Дотяг";
            //FpLift.label.Content = "Ліфт";
            //FpR2.label.Content = "Ручка 2";
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
            //double furPrice = fp.Dotjag(FpDot.Count) + fp.Lift(FpLift.Count) + fp.R2(FpR2.Count);
            return 0;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double price = TopPrice() + BottomPrice() + FurniturePlus();
            MessageBox.Show((price).ToString());
        }
    }
}
