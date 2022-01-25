using CompMaster.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMaster.Extension
{
    static class Data
    {
        public static ObservableCollection<MotherboardModel> MotherboardModels = new ObservableCollection<MotherboardModel>();
        public static ObservableCollection<ProcessorModel> ProcessorModels = new ObservableCollection<ProcessorModel>();
        public static ObservableCollection<BoxModel> BoxModels = new ObservableCollection<BoxModel>();
        public static ObservableCollection<VideoCardModel> VideoCardModels = new ObservableCollection<VideoCardModel>();
    }
}
