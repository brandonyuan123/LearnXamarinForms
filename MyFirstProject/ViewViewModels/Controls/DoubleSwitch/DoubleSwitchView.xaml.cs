using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModels.Controls.DoubleSwitch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoubleSwitchView : ContentPage
    {
        public DoubleSwitchView()
        {
            InitializeComponent();
            this.BindingContext = new DoubleSwitchViewModel();
        }

        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == false)
                label.TextColor = Color.Red;
            else
                label.TextColor = Color.Blue;
        }
    }
}