using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.DualPicker.VMPicker.VMResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DualPicker.VMPicker
{
    class VMPickerViewModel : BaseViewModel
    {
        public ICommand OnSubmitClicked { get; set; }
        public List<String> CharacterList { get; set; }
        public ImageSource SubmitImageSrc { get; set; }
        public string SelectedItem { get; set; }
        private Person result { get; set; }

        public VMPickerViewModel()
        {
            Title = Titles.VMPickerTitle;
            SubmitImageSrc = ImageSource.FromResource("MyFirstProject.Images.SubmitButton.png");

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
            GetCharacterList();
        }

        public void GetCharacterList()
        {
            var persons = Person.GetNameImages();

            CharacterList = (from p in persons select p.Name).ToList();
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(SelectedItem))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.PickerTitle, "A selection must be made", "Ok");
                return;
            }

            var persons = Person.GetNameImages();

            foreach (Person p in persons)
            {
                if (p.Name == SelectedItem)
                {
                    result = p;
                }
            }

            await Application.Current.MainPage.Navigation.PushAsync(new VMResultsView(result));
        }
    }
}
