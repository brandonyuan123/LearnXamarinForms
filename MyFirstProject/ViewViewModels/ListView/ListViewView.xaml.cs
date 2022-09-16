using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewView : ContentPage
    {
        public ListViewView()
        {
            InitializeComponent();
            this.BindingContext = new ListViewViewModel();
        }
    }
}