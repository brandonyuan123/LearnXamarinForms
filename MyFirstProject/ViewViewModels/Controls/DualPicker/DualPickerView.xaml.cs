using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DualPicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DualPickerView : ContentPage
    {
        public DualPickerView()
        {
            InitializeComponent();
            this.BindingContext = new DualPickerViewModel();
        }
    }
}