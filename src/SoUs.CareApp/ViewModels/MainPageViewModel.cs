using SoUs.Entities;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "Main Page";

            var a = new Assignment
            {
                Resident = new()
                {
                    Name = "Ibn Halfdan"
                },
                TimeStart = new(2024, 01, 01, 12, 00, 00),
                TimeEnd = new(2024, 01, 01, 12, 30, 00)
            };
            var b = new Assignment
            {
                Resident = new()
                {
                    Name = "Ib Bifrost"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };
            var c = new Assignment
            {
                Resident = new()
                {
                    Name = "Morten Skildpadde"
                },
                TimeStart = new(2024, 01, 01, 12, 00, 00),
                TimeEnd = new(2024, 01, 01, 12, 30, 00)
            };
            var d = new Assignment
            {
                Resident = new()
                {
                    Name = "Søren Banjomus"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };
            var e = new Assignment
            {
                Resident = new()
                {
                    Name = "Helle Helle"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };
            var f = new Assignment
            {
                Resident = new()
                {
                    Name = "Katrine Pandekage"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };
            var g = new Assignment
            {
                Resident = new()
                {
                    Name = "Karen Von Memes"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };

            TodaysAssignments.Add(a);
            TodaysAssignments.Add(b);
            TodaysAssignments.Add(c);
            TodaysAssignments.Add(d);
            TodaysAssignments.Add(e);
            TodaysAssignments.Add(f);
            TodaysAssignments.Add(g);
        }

        public ObservableCollection<Assignment> TodaysAssignments { get; } = new();
    }
}
