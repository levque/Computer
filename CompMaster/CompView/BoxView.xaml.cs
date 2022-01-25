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
    /// Interaction logic for BoxView.xaml
    /// </summary>
    public partial class BoxView : Window
    {
        private BoxModel selectedBoxModel;

        public BoxModel SelectedBoxModel
        {
            get => selectedBoxModel;
            set
            {
                selectedBoxModel = value;
                Signal();
            }
        }

        public ObservableCollection<BoxModel> Boxes
        {
            get => Data.BoxModels;
        }
        public BoxView()
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

        private void AddBox(object sender, RoutedEventArgs e)
        {
            Boxes.Add(new BoxModel { Name = "Модель" });
        }

        private void DeleteBox(object sender, RoutedEventArgs e)
        {
            if (SelectedBoxModel == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранный корпус?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Boxes.Remove(SelectedBoxModel);
            }
        }
    }
}
