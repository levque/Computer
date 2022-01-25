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
    /// Interaction logic for VideocardView.xaml
    /// </summary>
    public partial class VideocardView : Window
    {
        private VideoCardModel selectedVideoCardModel;

        public VideoCardModel SelectedVideoCardModel
        {
            get => selectedVideoCardModel;
            set
            {
                selectedVideoCardModel = value;
                Signal();
            }
        }

        public ObservableCollection<VideoCardModel> Videocards
        {
            get => Data.VideoCardModels;
        }
        public VideocardView()
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

        private void AddVideocard(object sender, RoutedEventArgs e)
        {
            Videocards.Add(new VideoCardModel { Name = "Модель" });
        }

        private void DeleteVideocard(object sender, RoutedEventArgs e)
        {
            if (SelectedVideoCardModel == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранный процессор?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Videocards.Remove(SelectedVideoCardModel);
            }
        }
    }
}
