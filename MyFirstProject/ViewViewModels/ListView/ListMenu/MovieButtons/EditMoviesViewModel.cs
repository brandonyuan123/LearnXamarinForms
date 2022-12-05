using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.MovieButtons
{
    class EditMoviesViewModel : BaseViewModel
    {
        public ICommand UpdateClicked { get; set; }
        private string _movieText = String.Empty;

        public EditMoviesViewModel()
        {
            Title = Titles.EditMoviesTitle;
            UpdateClicked = new Command(PerformSave);
        }

        public string MovieText
        {
            get { return _movieText; }

            set
            {
                if (_movieText != value)
                    SetProperty(ref _movieText, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_movieText.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddMoviesTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            Movies movies = new Movies();
            movies.Name = _movieText;

            MessagingCenter.Send<Movies>(movies, "UpdateMovies");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
