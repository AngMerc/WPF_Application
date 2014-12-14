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

namespace ShoppingSites
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Amazon_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Amazon.com");
        }

        private void Target_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Target.com");
        }

        private void Dicks_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.DicksSportingGoods.com");
        }

        private void Overstock_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Overstock.com");
        }

        private void _6pm_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.6pm.com");
        }
    }
}
