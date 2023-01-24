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
        private string _selectedItem;

        public ImageSource SubmitImageSrc { get; set; }

        public VMPickerViewModel()
        {
            Title = Titles.PickerTitle;
            SubmitImageSrc = ImageSource.FromResource("MyFirstProject.Images.SubmitButton.png");
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    SetProperty(ref _selectedItem, value);
                }
            }
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_selectedItem))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.PickerTitle, "A selection must be made", "Ok");
                return;
            }

            //stopped here last time
        }
    }
}
