using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Layout.Absolute.AbsolutePage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Layout.Absolute
{
    class AbsoluteViewModel : BaseViewModel
    {
        public AbsoluteViewModel()
        {
            Title = Titles.AbsolutePageTitle;
            OnAbsolutePageClicked = new Command(OnAbsolutePageClickedAsync);
        }

        public ICommand OnAbsolutePageClicked { get; set; }

        private async void OnAbsolutePageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsolutePageView());
        }
    }
}
