using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.MovieButtons
{
    class MovieButtonsViewModel : BaseViewModel
    {
        private List<Movies> movie;
        private ObservableCollection<Movies> movies;

        public MovieButtonsViewModel()
        {
            Title = Titles.MovieButtonsTitle;
            MovieCollection = new ObservableCollection<Movies>();
        }

        public ObservableCollection<Movies> MovieCollection
        {
            get
            {
                return movies;
            }
            set
            {
                movies = value;
                OnPropertyChanged();
            }
        }

        private void loadMovies()
        {
            try
            {
                movies.Clear();
                foreach (var p in movie)
                {
                    MovieCollection.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public Command<Movies> DeleteCommand
        {
            get
            {
                return new Command<Movies>((Movies mov) =>
                {
                    MovieCollection.Remove(mov);
                });
            }
        }

        public Command<Movies> UpdateCommand
        {
            get
            {
                return new Command<Movies>((Movies mov) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new EditMoviesView(mov));

                    MessagingCenter.Subscribe<Movies>(this, "UpdateMovies", async (data) =>
                    {
                        var index = MovieCollection.IndexOf(mov);
                        MovieCollection.RemoveAt(index);
                        MovieCollection.Insert(index, data);
                        MessagingCenter.Unsubscribe<Movies>(this, "UpdateMovies");
                    });
                });
            }
        }
    }
}
