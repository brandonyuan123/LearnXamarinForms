using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.MovieButtons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieButtonsView : ContentPage
    {
        public MovieButtonsView()
        {
            InitializeComponent();
            this.BindingContext = new MovieButtonsViewModel();
        }
    }
}