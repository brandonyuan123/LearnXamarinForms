using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.ListView.ListMenu.DisplayPeople;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu
{
    class ListMenuViewModel : BaseViewModel
    {   
        public ICommand OnDisplayPeopleClicked { get; set; }

        public ListMenuViewModel()
        {
            Title = Titles.ListMenuTitle;
            OnDisplayPeopleClicked = new Command(OnDisplayPeopleClickedAsync);
        }

        private async void OnDisplayPeopleClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DisplayPeopleView());
        }
    }
}
