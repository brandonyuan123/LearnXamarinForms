using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.DisplayImages
{
    class DisplayImagesViewModel : BaseViewModel
    {
        public ObservableCollection<Person> PersonsCollection { get; }
        private List<Person> PersonsList;

        public DisplayImagesViewModel()
        {
            Title = Titles.DisplayImagesTitle;
            PersonsCollection = new ObservableCollection<Person>();
            PersonsList = Person.GetNameImages();
            this.LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                PersonsCollection.Clear();
                foreach (var p in PersonsList)
                {
                    PersonsCollection.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
