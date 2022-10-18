using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Image.ImageMenu.EmbeddedImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImageView : ContentPage
    {
        public EmbeddedImageView()
        {
            InitializeComponent();
            this.BindingContext = new EmbeddedImageViewModel();
        }
    }
}