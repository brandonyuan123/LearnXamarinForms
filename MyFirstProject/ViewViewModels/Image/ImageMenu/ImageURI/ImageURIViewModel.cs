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
            var imgsrc = new UriImageSource { Uri = new Uri("https://media.architecturaldigest.com/photos/58f918044f42bd463db36a3f/4:3/w_2663,h_1997,c_limit/1%20-%2010%20Greenest%20Cities%20in%20America%20in%202017.jpg") };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }   
}
