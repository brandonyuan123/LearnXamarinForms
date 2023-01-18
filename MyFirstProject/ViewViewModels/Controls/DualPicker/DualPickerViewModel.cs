using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DualPicker
{
    class DualPickerViewModel : BaseViewModel
    {
        public ImageSource VMPickerImageSrc { get; set; }

        public DualPickerViewModel()
        {
            VMPickerImageSrc = ImageSource.FromResource("MyFirstProject.Images.buttonblue.png");
        }
    }
}
