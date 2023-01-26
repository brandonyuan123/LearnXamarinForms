using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DualPicker.VMPicker.VMResults
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VMResultsView : ContentPage
    {
        public VMResultsView(Person person)
        {
            InitializeComponent();
            this.BindingContext = new VMResultsViewModel();

            selectedCharacter.Text = person.Name;
            characterImage.Source = person.URI;
        }
    }
}