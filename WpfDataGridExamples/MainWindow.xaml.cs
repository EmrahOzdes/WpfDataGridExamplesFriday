using System;
using System.Collections.Generic;
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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customers> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Customers>()
            {
                new Customers() {AD="Ali",SOYAD="CAN" },
                new Customers() {AD="Alihan",SOYAD="CANLI" },
                new Customers() {AD="Alican",SOYAD="CANSIZ" },
                new Customers() {AD="Aliye",SOYAD="CANMI" },
                new Customers() {AD="Mahmut",SOYAD="CANNIMIZ" },
                new Customers() {AD="Kemal",SOYAD="CANCAN" },
                new Customers() {AD="Kemaliye",SOYAD="CANKAN" },
                new Customers() {AD="Kelamin",SOYAD="CANISI" },

            };
            Customers lst = new Customers();
            lst.AD = "Mehmet";
            lst.SOYAD = "YAĞIZ";
            list.Add(lst);
        }

        private void btntikla_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butona Tıklandı.");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cmbBoxListe.SelectedItem.ToString());

            MessageBox.Show(((ComboBoxItem)(cmbBoxListe.SelectedItem)).Content.ToString());
        }
        internal class Customers
        {
            public string AD { get; internal set; }
            public string SOYAD { get; internal set; }
        }
        public void Window_Load(object sender,RoutedEventArgs e)
        {
            tb1.ItemsSource = list;
        }


    }
   


}
