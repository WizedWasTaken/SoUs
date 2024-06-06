using CommunityToolkit.Mvvm.ComponentModel;
using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.CareApp.ViewModels
{
    [QueryProperty("Assignment", "Assignment")]
    public partial class SubTaskPageViewmodel : BaseViewModel
    {
        public SubTaskPageViewmodel()
        {
        }

        [ObservableProperty]
        Assignment assignment;
    }
}
