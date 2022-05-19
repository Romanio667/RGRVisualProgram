using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using MiroshnichenkoCurs.Models;

namespace MiroshnichenkoCurs.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateGrid();
            CreateRequests();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }

        ObservableCollection<Tabs> tab;
        public ObservableCollection<Tabs> Tab
        {
            get { return tab; }
            set { this.RaiseAndSetIfChanged(ref tab, value); }
        }
        private void CreateTabs()
        {
            Tab = new ObservableCollection<Tabs>();
            Tab.Add(new Tabs("player",false));
            Tab.Add(new Tabs("trainer", false));
            Tab.Add(new Tabs("match", false));
            Tab.Add(new Tabs("team", false));
            Tab.Add(new Tabs("country", false));
            Tab.Add(new Tabs("ground", false));
            Tab.Add(new Tabs("season", false));
            Tab.Add(new Tabs("Запрос 1", true));
            Tab.Add(new Tabs("Запрос 2", true));
            Tab.Add(new Tabs("Запрос 3", true));

        }

        ObservableCollection<Tabs> request;
        public ObservableCollection<Tabs> Request
        {
            get { return request; }
            set { this.RaiseAndSetIfChanged(ref request, value); }
        }

        private void CreateRequests()
        {
            Request = new ObservableCollection<Tabs>();
            Request.Add(new Tabs("Запрос 1", true));
            Request.Add(new Tabs("Запрос 2", true));
            Request.Add(new Tabs("Запрос 3", true));
        }

        ObservableCollection<Grids> grid;
        public ObservableCollection<Grids> Grid
        {
            get { return grid; }
            set { this.RaiseAndSetIfChanged(ref grid, value); }
        }
        private void CreateGrid()
        {
            Grid = new ObservableCollection<Grids>();
            Grid.Add(new Grids("1", "Ivan M.N.", "2" , "127", "1233", "630", "1410"));
            Grid.Add(new Grids("2", "Sergey M.E.", "3", "114", "1421", "1109", "1539"));
            Grid.Add(new Grids("3", "Ilya E.T.", "4", "81", "4353", "702", "1146"));
            Grid.Add(new Grids("4", "Vitja O.W", "5", "108", "283", "892", "1409"));
            Grid.Add(new Grids("5", "Oleg W.E.", "2", "93", "283", "299", "1456"));
            Grid.Add(new Grids("6", "Alex V.E.", "1", "79", "231", "631", "1197"));
        }



        


    }
}
