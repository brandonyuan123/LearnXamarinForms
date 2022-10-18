using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Image.ImageMenu.EmbeddedImage;
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
        public ICommand OnEmbeddedImageClicked { get; set; }
        public ImageMenuViewModel()
        {
            Title = Titles.ImageMenuTitle;
            OnImageURIClicked = new Command(OnEmbeddedImageClickedAsync);
            OnEmbeddedImageClicked = new Command(OnEmbeddedImageClickedAsync);
        }

        private async void OnEmbeddedImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageView());
        }
    }
}
