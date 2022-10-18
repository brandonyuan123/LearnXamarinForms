using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.ImageMenu.EmbeddedImage
{
    class EmbeddedImageViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc { get; set; }
        public EmbeddedImageViewModel()
        {
            Title = Titles.EmbeddedImageTitle;
        }

        private void getEmbeddedImageSrc()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Images.wah.jfif");
        }
    }
}
