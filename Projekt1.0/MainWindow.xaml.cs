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

namespace Projekt1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CrossSectionCharacteristic przekroj1 = new CrossSectionCharacteristic();
        public MainWindow()
        {
            InitializeComponent();
            przekroj1.h = 0;
            przekroj1.b = 0;
            refreshboxa(przekroj1.a);
        }

        private void refreshboxa(double wynik)
        {
            this.abox.Text = wynik.ToString();
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            Double high = Double.Parse(hbox.Text.Replace('.', ','));
            przekroj1.h = high;
           
            Double width = Double.Parse(bbox.Text.Replace('.', ','));
            przekroj1.b = width;
            refreshboxa(przekroj1.a);
            
        }
    }
}
