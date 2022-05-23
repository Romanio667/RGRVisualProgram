using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;

using System.Text;

namespace RGR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase content;
        public ViewModelBase Content
        {
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public ObservableCollection<player> Players { get; set; }
        public ObservableCollection<country> Countries { get; set; }
        public ObservableCollection<team> Teams { get; set; }
        public ObservableCollection<season> Season { get; set; }
        public ObservableCollection<ground> Ground { get; set; }
        public ObservableCollection<trainer> Trainer { get; set; }
        public ObservableCollection<match> Match { get; set; }

        public MainWindowViewModel()
        {
            Players = new ObservableCollection<player>();
            Countries = new ObservableCollection<country>();
            Teams = new ObservableCollection<team>();
            Season = new ObservableCollection<season>();
            Ground = new ObservableCollection<ground>();
            Trainer = new ObservableCollection<trainer>();
            Match = new ObservableCollection<match>();

            using (var db = new data_baseContext())
            {
                foreach (var record in db.Players) Players.Add(record);
                foreach (var record in db.Countries) Countries.Add(record);
                foreach (var record in db.Teams) Teams.Add(record);
                foreach (var record in db.Season) Season.Add(record);
                foreach (var record in db.Ground) Ground.Add(record);
                foreach (var record in db.Trainer) Trainer.Add(record);
                foreach (var record in db.Match) Match.Add(record);
            }

            Content = new DataBaseViewModel();
        }
    }
}
