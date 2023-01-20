using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using MyFirstProject.ViewViewModels.Controls.DualPicker.VMPicker;
using MyFirstProject.ViewViewModels.Controls.Picker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Controls.DualPicker
{
    class DualPickerViewModel : BaseViewModel
    {
        //Images
        public ImageSource VMPicker { get; set; }
        public ImageSource XAMLPicker { get; set; }

        public List<String> CharacterList { get; set; }

        //Navigation
        public ICommand OnXAMLClicked { get; set; }
        public ICommand OnVMClicked { get; set; }



        public DualPickerViewModel()
        {
            VMPicker = ImageSource.FromResource("MyFirstProject.Images.buttonblue.png");
            XAMLPicker = ImageSource.FromResource("MyFirstProject.Images.buttonred.png");

            OnXAMLClicked = new Command(OnXAMLClickedAsync);
            OnVMClicked = new Command(OnVMClickedAsync);
        }

        private async void OnXAMLClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerView());
        }

        private async void OnVMClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new VMPickerView());
        }

        private void GetCharacterList()
        {
            List<Person> names = Person.GetNameImages();
            CharacterList = (from p in names select p.Name).ToList();
        }
    }
}
