using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.MovieButtons
{
    class MovieButtonsViewModel : BaseViewModel
    {
        private List<Movies> movie;
        private ObservableCollection<Movies> movies;

        public MovieButtonsViewModel()
        {
            Title = Titles.MovieButtonsTitle;
            //MovieCollection = new ObservableCollection<Movies>();
        }
    }
}
