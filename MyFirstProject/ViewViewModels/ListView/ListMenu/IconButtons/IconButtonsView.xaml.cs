using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IconButtonsView : ContentPage
    {
        public IconButtonsView()
        {
            InitializeComponent();
            this.BindingContext = new IconButtonsViewModel();
        }
    }
}