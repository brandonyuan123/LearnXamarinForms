using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DatePickerMenu.DatePickerVM
{
    class DatePickerVMViewModel : BaseViewModel
    {
        public ImageSource img { get; set; }
        public ICommand SubmitClicked { get; set; }

        public DateTime min { get; set; }
        public DateTime max { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public bool isSwitch { get; set; }

        public DatePickerVMViewModel()
        {
            img = ImageSource.FromResource("MyFirstProject.Images.SubmitButton.png");

            SubmitClicked = new Command(SubmitClickedAsync);

            min = new DateTime(2021, 01, 01);
            max = new DateTime(2025, 01, 01);

            Title = Titles.DatePickerVMTitle;
        }

        private async void SubmitClickedAsync(object obj)
        {
            if (CheckDates())
            {
                if (isSwitch)
                {
                    var difference = end.Subtract(start).ToString();
                    await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVMTitle, "the start date is " + start.ToShortDateString() +
                        " and the end date is " + end.ToShortDateString() + " and the difference is " + difference, "Ok");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVMTitle, "the start date is " + start.ToShortDateString() +
                        " and the end date is " + end.ToShortDateString(), "Ok");

                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(Titles.DatePickerVMTitle, "the date picked are invalid", "Ok");
            }
        }

        private bool CheckDates()
        {
            if (start < min)
            {
                return false;
            }
            else if (end > max)
            {
                return false;
            }
            else if (start > end)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




    }
}
