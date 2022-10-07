using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Image.ImageMenu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image
{
    public class ImageViewModel : BaseViewModel
    {
        public ICommand OnImageMenuClicked { get; set; }
        public ImageViewModel()
        {
            Title = Titles.ImageTitle;
            OnImageMenuClicked = new Command(OnImageMenuClickedAsync);

        }

        private async void OnImageMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageMenuView());
        }
    }
}
