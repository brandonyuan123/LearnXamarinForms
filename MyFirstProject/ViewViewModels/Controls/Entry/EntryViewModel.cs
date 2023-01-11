using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.Entry.Results;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    class EntryViewModel:BaseViewModel
    {
        public ObservableCollection<Entries> entries;

        public ICommand OnEntryClicked { get; }
        public ICommand OnResultsClicked { get; }

        private string _entryText = string.Empty;

        public EntryViewModel()
        {
            Title = Titles.EntryTitle;
            OnEntryClicked = new Command(OnEntryClickedAsync);
            OnResultsClicked = new Command(OnResultsClickedAsync);
        }

        public string EntryText
        {
            get { return _entryText; }

            set
            {
                if (_entryText != value)
                    SetProperty(ref _entryText, value);
            }
        }

        private async void OnEntryClickedAsync (object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.EntryTitle, "Entry can't be empty!", "Ok");
                return;
            }
        }

        public ObservableCollection<Entries> EntryCollection
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

        private async void OnResultsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ResultsView());
            Entries entries = new Entries();
            MessagingCenter.Send<Entries>(entries, EntryText);
        }
    }
}
