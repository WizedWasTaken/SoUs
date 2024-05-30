﻿using SoUs.Entities;
using SoUs.Services;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ISoUsService sosuService;

        public ObservableCollection<Assignment> TodaysAssignments { get; } = new();

        public MainPageViewModel(ISoUsService sosuService)
        {
            Title = "DAGENS OPGAVER";
            this.sosuService = sosuService;
            UpdateAssignmentsAsync();

            var a = new Assignment
            {
                Resident = new()
                {
                    Name = "Ibn Halfdan",
                    RoomNumber = "A2"
                },
                TimeStart = new(2024, 01, 01, 12, 00, 00),
                TimeEnd = new(2024, 01, 01, 12, 30, 00)
            };
            var b = new Assignment
            {
                Resident = new()
                {
                    Name = "Ib Bifrost",
                    RoomNumber = "A1"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00),
                IsCompleted = true
            };

            TodaysAssignments.Add(a);
            TodaysAssignments.Add(b);
        }

        private async Task UpdateAssignmentsAsync()
        {
    }
}
