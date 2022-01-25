using CompMaster.CompView;
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

namespace CompMaster
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MotherboardView win = new MotherboardView();
            win.ShowDialog();
        }

        private void OpenBox_Click(object sender, RoutedEventArgs e)
        {
            BoxView win = new BoxView();
            win.ShowDialog();
        }

        private void OpenVidecard_Click(object sender, RoutedEventArgs e)
        {
            VideocardView win = new VideocardView();
            win.ShowDialog();
        }

        private void OpenProcessor_Click(object sender, RoutedEventArgs e)
        {
            ProcessorView win = new ProcessorView();
            win.ShowDialog();
        }
    }
}
