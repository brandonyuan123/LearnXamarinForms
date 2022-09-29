using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout.Absolute.AbsolutePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePageView : ContentPage
    {
        public AbsolutePageView()
        {
            InitializeComponent();
            this.BindingContext = new AbsolutePageViewModel();
        }
    }
}