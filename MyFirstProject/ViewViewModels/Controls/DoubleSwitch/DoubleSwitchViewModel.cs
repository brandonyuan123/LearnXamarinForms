using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.DoubleSwitch
{
    class DoubleSwitchViewModel : BaseViewModel
    {
        public Boolean Switch1 { get; set; }
        public Boolean Switch2 { get; set; }

        public DoubleSwitchViewModel()
        {
            Title = Titles.DoubleSwitchTitle;
            Switch1 = false;
            Switch2 = true;
        }
        

    }
}
