using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Image.ImageURI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.ImageMenu
{
    class ImageMenuViewModel : BaseViewModel
    {
        public ICommand OnImageURIClicked { get; set; }
        public ImageMenuViewModel()
        {
            Title = Titles.ImageMenuTitle;
            OnImageURIClicked = new Command(OnImageURIClickedAsync);
        }

        private async void OnImageURIClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageURIView());
        }
    }
}
