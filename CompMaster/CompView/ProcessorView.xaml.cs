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
    /// Interaction logic for ProcessorView.xaml
    /// </summary>
    public partial class ProcessorView : Window
    {
        private ProcessorModel selectedProcessorModel;

        public ProcessorModel SelectedProcessorModel
        {
            get => selectedProcessorModel;
            set
            {
                selectedProcessorModel = value;
                Signal();
            }
        }

        public ObservableCollection<ProcessorModel> Processors
        {
            get => Data.ProcessorModels;
        }
        public ProcessorView()
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

        private void AddProcessor(object sender, RoutedEventArgs e)
        {
            Processors.Add(new ProcessorModel { Name = "Модель" });
        }

        private void DeleteProcessor(object sender, RoutedEventArgs e)
        {
            if (SelectedProcessorModel == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранный процессор?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Processors.Remove(SelectedProcessorModel);
            }
        }
    }
}
