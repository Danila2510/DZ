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

namespace dz_12_10_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private string lang = "Eng";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_change_lng_Click(object sender, RoutedEventArgs e)
        {
            if (lang == "Eng")
            {
                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = new Uri("Resources/lang.ua-UA.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries[0] = newDictionary;
                lang = "Ukr";
            }
            else
            {
                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = new Uri("Resources/lang.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries[0] = newDictionary;
                lang = "Eng";
            }
        }
    }
}
