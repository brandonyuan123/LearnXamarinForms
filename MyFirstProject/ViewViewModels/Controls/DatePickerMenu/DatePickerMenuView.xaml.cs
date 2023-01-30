using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DatePickerMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerMenuView : ContentPage
    {
        public DatePickerMenuView()
        {
            InitializeComponent();
            this.BindingContext = new DatePickerMenuViewModel();
        }
    }
}