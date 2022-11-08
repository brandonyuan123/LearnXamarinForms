using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.ListView.ListMenu.DisplayImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayImagesView : ContentPage
    {
        public DisplayImagesView()
        {
            this.BindingContext = new DisplayImagesViewModel();
            InitializeComponent();
        }
    }
}