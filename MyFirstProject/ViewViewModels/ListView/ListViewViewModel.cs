using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.ListView.ListMenu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.ListView
{
    public class ListViewViewModel : BaseViewModel
    {
        public ICommand OnListMenuClicked { get; set; }

        public ListViewViewModel()
        {
            Title = Titles.ListViewTitle;
            OnListMenuClicked = new Command(OnListMenuClickedAsync);
        }

        private async void OnListMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListMenuView());
        }
    }
}
