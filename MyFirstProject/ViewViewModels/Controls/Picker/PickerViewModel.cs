using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.Entry.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerViewModel : BaseViewModel
    {
        public ImageSource SubmitImageSrc { get; set; }
        public ICommand OnResultsClicked { get; set; }

        public PickerViewModel()
        {
            Title = Titles.PickerTitle;
            SubmitImageSrc = ImageSource.FromResource("MyFirstProject.Images.SubmitButton.png");

            OnResultsClicked = new Command(OnResultsClickedAsync);
        }

        private async void OnResultsClickedAsync(object obj)
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new ResultsView());
        }
    }
}
