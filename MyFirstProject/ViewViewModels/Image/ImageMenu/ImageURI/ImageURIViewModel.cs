using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.ImageURI
{
    class ImageURIViewModel :BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }
        public ImageURIViewModel()
        {
            Title = Titles.ImageURITitle;
            ImageSrc = this.SetImageSrc();
        }

        private ImageSource SetImageSrc()
        {
            var imgsrc = new UriImageSource {Uri = new Uri(Images.ImageURI)};
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }   
}
