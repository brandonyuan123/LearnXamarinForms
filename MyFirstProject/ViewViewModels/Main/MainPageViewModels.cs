using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls;
using MyFirstProject.ViewViewModels.Image;
using MyFirstProject.ViewViewModels.Layout;
using MyFirstProject.ViewViewModels.ListView;
using MyFirstProject.ViewViewModels.SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Main
{
    public class MainPageViewModels : BaseViewModel
    {
        public ICommand OnLayoutClicked { get; set; }
        public ICommand OnImageClicked { get; set; }
        public ICommand OnListViewClicked { get; set; }
        public ICommand OnControlsClicked { get; set; }
        public ICommand OnSQLiteClicked { get; set; }



        string subtitle = string.Empty;
        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }

        public MainPageViewModels()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;
            OnLayoutClicked = new Command(OnLayoutClickedAsync);
            OnImageClicked = new Command(OnImageClickedAsync);
            OnListViewClicked = new Command(OnListViewClickedAsync);
            OnControlsClicked = new Command(OnControlsClickedAsync);
            OnSQLiteClicked = new Command(OnSQLiteClickedAsync);
        }

        private async void OnLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
        }

        private async void OnImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageView());
        }

        private async void OnControlsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsView());
        }

        private async void OnListViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewView());
        }

        private async void OnSQLiteClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SQLiteView());
        }
    }
}
