using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Entry.Results
{
    class ResultsViewModel : BaseViewModel
    {
        public ObservableCollection<String> entries;

        public ResultsViewModel()
        {
            Title = Titles.ResultsTitle;
        }

        public ObservableCollection<String> EntriesCollection
        {
            get
            {
                return entries;
            }
            set
            {
                entries = value;
                OnPropertyChanged();
            }
        }




        //need to receive msg from msging center
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
    }
}
