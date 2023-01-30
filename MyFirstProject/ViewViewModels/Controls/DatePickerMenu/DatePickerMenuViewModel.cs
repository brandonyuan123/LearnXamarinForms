using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.DatePickerMenu.DatePickerVM;
using MyFirstProject.ViewViewModels.Controls.DatePickerMenu.DatePickerXAML;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DatePickerMenu
{
    class DatePickerMenuViewModel : BaseViewModel
    {
        public ImageSource XAMLPicker { get; set; }
        public ImageSource VMPicker { get; set; }

        public ICommand OnXAMLClicked { get; set; }
        public ICommand OnVMClicked { get; set; }

        public DatePickerMenuViewModel()
        {
            Title = Titles.DatePickerMenuTitle;

            XAMLPicker = ImageSource.FromResource("MyFirstProject.Images.dpbuttonred.png");
            VMPicker = ImageSource.FromResource("MyFirstProject.Images.dpbuttonblue.png");

            OnXAMLClicked = new Command(OnXAMLClickedAsync);
            OnVMClicked = new Command(OnVMClickedAsync);
        }

        private async void OnXAMLClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerXAMLView());
        }
        private async void OnVMClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVMView());
        }
    }
}
