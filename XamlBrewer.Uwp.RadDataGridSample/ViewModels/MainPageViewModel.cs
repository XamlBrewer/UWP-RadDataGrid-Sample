using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvvm;
using XamlBrewer.Uwp.RadDataGridSample.Data;
using XamlBrewer.Uwp.RadDataGridSample.Models;

namespace XamlBrewer.Uwp.RadDataGridSample.ViewModels
{
    internal class MainPageViewModel : ViewModelBase
    {
        public List<Driver> Drivers => Dal.Drivers;
    }
}
