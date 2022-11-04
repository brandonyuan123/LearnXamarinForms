using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.DisplayPeople
{
    class DisplayPeopleViewModel : BaseViewModel
    {
        public ObservableCollection<Person> PersonsCollection { get; }

        private List<Person> personList;

        public DisplayPeopleViewModel ()
        {
            Title = Titles.DisplayPeopleTitle;
            PersonsCollection = new ObservableCollection<Person>();
            personList = Person.getNames();
            this.LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                PersonsCollection.Clear();
                foreach (var p in personList)
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
