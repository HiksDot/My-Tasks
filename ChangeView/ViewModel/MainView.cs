using System;
using System.Collections.Generic;
using System.Text;
using My_Tasks.Core;

namespace My_Tasks.ChangeView.ViewModel
{
    class MainView: ObservablesObjects
    {
        public RelayCommand SchoolViewCommand { get; set; }
        public RelayCommand DailyViewCommand { get; set; }
        public RelayCommand ProjectsViewCommand { get; set; }
        public RelayCommand CodingViewCommand { get; set; }
        public SchoolView SchoolView { get; set; }
        public CodingView CodingView { get; set; }
        public DailyView DailyView { get; set; }
        public ProjectsView ProjectsView { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        
        public MainView()
        {
            SchoolView = new SchoolView();
            CodingView = new CodingView();
            DailyView = new DailyView();
            ProjectsView = new ProjectsView();

            SchoolViewCommand = new RelayCommand(o =>
            {
                CurrentView = SchoolView;
            });

            CodingViewCommand = new RelayCommand(o =>
            {
                CurrentView = CodingView;
            });

            DailyViewCommand = new RelayCommand(o =>
            {
                CurrentView = DailyView;
            });

           ProjectsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ProjectsView;
            });
        }

    }
}
