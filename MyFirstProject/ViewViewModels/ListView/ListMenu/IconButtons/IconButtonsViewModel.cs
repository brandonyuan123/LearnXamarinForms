using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.ListView.ListMenu.MovieButtons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu
{
    class IconButtonsViewModel : BaseViewModel
    {
        private List<Movies> movie;
        private ObservableCollection<Movies> movies;

        public ImageSource EditImageSrc { get; set; }
        public ImageSource DeleteImageSrc { get; set; }

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

        public IconButtonsViewModel()
        {
            Title = Titles.IconButtonsTitle;
            MovieCollection = new ObservableCollection<Movies>();
            movie = Movies.GetMovies();
            this.LoadMovies();

            EditImageSrc = ImageSource.FromResource("MyFirstProject.Images.iconsedit.png");
            DeleteImageSrc = ImageSource.FromResource("MyFirstProject.Images.iconsdelete.png");
        }

        private void LoadMovies()
        {
            IsBusy = true;

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
            finally
            {
                IsBusy = false;
            }
        }

        public Command AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new AddMoviesView());

                    MessagingCenter.Subscribe<Movies>(this, "AddMovies", async (data) =>
                    {
                        MovieCollection.Add(data);
                        MessagingCenter.Unsubscribe<Movies>(this, "AddMovies");
                    });
                });
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
