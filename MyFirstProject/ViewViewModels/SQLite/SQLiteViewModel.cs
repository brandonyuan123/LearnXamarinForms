using MyFirstProject.Models;
using MyFirstProject.Patterns.Repositories;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Dbase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.SQLite
{
    public class SQLiteViewModel : BaseViewModel
    {
        private ObservableCollection<Vacation> _vacationCollection;

        public ObservableCollection<Vacation> VacationCollection
        {
            get { return _vacationCollection; }
            set
            {
                _vacationCollection = value;
                OnPropertyChanged();
            }
        }

        public SQLiteViewModel()
        {
            VacationCollection = new ObservableCollection<Vacation>();
            Task.Run(async () => await RefreshVacationListData());

            MessagingCenter.Subscribe<object>(this, "RefreshData", async (sender) =>
            {
                await RefreshVacationListData();
            });

            Title = Titles.SQLiteTitle;
        }

        private async Task RefreshVacationListData()
        {
            var vacation = DependencyService.Get<ISQLite>().GetVacation();
            VacationCollection = new ObservableCollection<Vacation>(vacation);
        }

        public Command AddCommand
        {
            get
            {
                return new Command<Vacation>((Vacation vacation) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new SQLiteAddVacationView(vacation));
                    MessagingCenter.Subscribe<Vacation>(this, "AddVacation", async (data) =>
                    {
                        await RefreshVacationListData();
                        MessagingCenter.Unsubscribe<Vacation>(this, "AddVacation");
                    });
                });

            }
        }

        public Command<Vacation> DeleteCommand
        {
            get
            {
                return new Command<Vacation>((Vacation vacation) =>
                {
                    DependecyService.Get<ISQLite>().DeleteVacation(vacation.ID);
                    VacationCollection.Remove(vacation);
                });
            }
        }
    }
}
