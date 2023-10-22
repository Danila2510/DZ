using My_Localization_1_1.Resourses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace dz_12_10_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool lang_change = false;
        public MainWindow()
        {
            InitializeComponent();
        }
    

        private void UpdateUI()
        {
            Title = lang.winTitle;
            l_name.Content = lang.l_name;
            l_surname.Content = lang.l_surname;
            l_phone.Content = lang.l_phone;
            b_cancel.Content = lang.b_cancel;
            b_change_lng.Content = lang.b_change_lng;
        }


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }

        private void Change_lng_Click(object sender, RoutedEventArgs e)
        {
            if (lang_change)
            {
                MenuLangEN_Click(sender, e);
                lang_change = false;
            }
            else
            {
                MenuLangUA_Click(sender, e);
                lang_change = true;
            }
        }

        private void MenuLangUA_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk");
            UpdateUI();
        }

        private void MenuLangEN_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            UpdateUI();
        }
    }
}
