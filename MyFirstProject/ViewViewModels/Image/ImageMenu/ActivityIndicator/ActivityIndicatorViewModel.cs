using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.ImageMenu.ActivityIndicator
{
    class ActivityIndicatorViewModel: BaseViewModel
    {
        public ActivityIndicatorViewModel()
        {
            Title = Titles.ActivityIndicatorTitle;
            ImageSrc = this.SetImageSrc();
        }

        public ImageSource ImageSrc { get; set; }

        private ImageSource SetImageSrc()
        {
            var imgsrc = new UriImageSource { Uri = new Uri(Images.ImageURI) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }
}
