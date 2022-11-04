using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.DisplayPeople
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPeopleView : ContentPage
    {
        public DisplayPeopleView()
        {
            InitializeComponent();
            this.BindingContext = new ListMenuViewModel();
        }
    }
}