using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.ImageMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageMenuView : ContentPage
    {
        public ImageMenuView()
        {
            InitializeComponent();
            this.BindingContext = new ImageMenuViewModel();
        }
    }
}