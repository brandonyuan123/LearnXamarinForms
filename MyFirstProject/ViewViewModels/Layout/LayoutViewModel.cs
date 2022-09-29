using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Layout.Absolute;
using MyFirstProject.ViewViewModels.Layout.Absolute.AbsolutePage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layout
{

    public class LayoutViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteClicked { get; set; }
        public LayoutViewModel()
        {
            Title = Titles.LayoutTitle;
            OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
            OnAbsolutePageClicked = new Command(OnAbsolutePageClickedAsync);
        }

        private async void OnAbsoluteClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteView());
        }
        public ICommand OnAbsolutePageClicked { get; set; }

        private async void OnAbsolutePageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsolutePageView());
        }
    }
}
