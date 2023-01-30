using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DatePickerMenu.DatePickerVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerVMView : ContentPage
    {


        public DatePickerVMView()
        {
            InitializeComponent();
            this.BindingContext = new DatePickerVMViewModel();
        }
        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var start = (DatePickerVMViewModel)BindingContext;
            start.start = e.NewDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var start = (DatePickerVMViewModel)BindingContext;
            start.end = e.NewDate;
        }
    }
}