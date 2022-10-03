using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout.Relative
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeView : ContentPage
    {
        public RelativeView()
        {
            InitializeComponent();
            this.BindingContext = new RelativeViewModel();
        }
    }
}