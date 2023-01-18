using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerViewModel : BaseViewModel
    {
        public ImageSource SubmitImageSrc { get; set; }

        public PickerViewModel()
        {
            Title = Titles.PickerTitle;
            SubmitImageSrc = ImageSource.FromResource("MyFirstProject.Images.SubmitButton.png");
        }
    }
}
