using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DualPicker.VMPicker
{
    class VMPickerViewModel : BaseViewModel
    {
        public ImageSource SubmitImageSrc { get; set; }

        public VMPickerViewModel()
        {
            Title = Titles.PickerTitle;
            SubmitImageSrc = ImageSource.FromResource("MyFirstProject.Images.SubmitButton.png");
        }
    }
}
