using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout.Absolute
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteView : ContentPage
    {
        public AbsoluteView()
        {
            InitializeComponent();
            this.BindingContext = new AbsoluteViewModel();
        }
    }
}