using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Layout;
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
        }

        private async void OnLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
        }
    }
}
