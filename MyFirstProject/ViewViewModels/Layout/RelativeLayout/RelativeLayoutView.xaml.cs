using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Layout.RelativeLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutView : ContentPage
    {
        public RelativeLayoutView()
        {
            InitializeComponent();
            this.BindingContext = new RelativeLayoutViewModel();
        }
    }
}