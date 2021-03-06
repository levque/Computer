using CompMaster.Extension;
using CompMaster.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompMaster.CompView
{
    /// <summary>
    /// Interaction logic for MotherboardView.xaml
    /// </summary>
    public partial class MotherboardView : Window
    {
        private MotherboardModel selectedMotherboardModel;

        public MotherboardModel SelectedMotherboardModel
        {
            get => selectedMotherboardModel;
            set
            {
                selectedMotherboardModel = value;
                Signal();
            }
        }

        public ObservableCollection<MotherboardModel> Motherboards
        {
            get => Data.MotherboardModels;
        }
        public MotherboardView()
        {
            InitializeComponent();
            DataContext = this;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddMotherboard(object sender, RoutedEventArgs e)
        {
            Motherboards.Add(new MotherboardModel { Name = "Модель" });
        }

        private void DeleteMotherboard(object sender, RoutedEventArgs e)
        {
            if (SelectedMotherboardModel == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранную материнскую плату?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Motherboards.Remove(SelectedMotherboardModel);
            }
        }
    }
}

