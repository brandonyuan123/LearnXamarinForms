using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.MovieButtons
{
    class AddMoviesViewModel : BaseViewModel
    {
        public ICommand SaveBtnClicked { get; set; }
        private string _movieText = String.Empty;

        public AddMoviesViewModel()
        {
            Title = Titles.AddMoviesTitle;
            SaveBtnClicked = new Command(PerformSave);
        }

        public string MovieText
        {
            get { return _movieText; }
            set
            {
                if (_movieText != value)
                {
                    SetProperty(ref _movieText, value);
                }
            }
        }

        public void PerformSave()
        {
            if (String.IsNullOrEmpty(_movieText.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddMoviesTitle, Msgs.NotEmpty, "OK");
                return;
            }

            Movies movies = new Movies();
            movies.Name = _movieText;

            MessagingCenter.Send<Movies>(movies, "AddMovies");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
