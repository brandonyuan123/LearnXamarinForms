using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Layout.Absolute;
using MyFirstProject.ViewViewModels.Layout.Absolute.AbsolutePage;
using MyFirstProject.ViewViewModels.Layout.Relative;
using MyFirstProject.ViewViewModels.Layout.RelativeLayout;
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
        public ICommand OnAbsolutePageClicked { get; set; }
        public ICommand OnRelativeClicked { get; set; }
        public ICommand OnRelativeLayoutClicked { get; set; }
        public LayoutViewModel()
        {
            Title = Titles.LayoutTitle;
            OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
            OnAbsolutePageClicked = new Command(OnAbsolutePageClickedAsync);
            OnRelativeClicked = new Command(OnRelativeClickedAsync);
            OnRelativeLayoutClicked = new Command(OnRelativeLayoutClickedAsync);
        }

        private async void OnAbsoluteClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteView());
        }

        private async void OnAbsolutePageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsolutePageView());
        }

        private async void OnRelativeClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeView());
        }
        private async void OnRelativeLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutView());
        }
    }
}
