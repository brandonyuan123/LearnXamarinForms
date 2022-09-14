using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Main
{
    public class MainPageViewModels : BaseViewModel
    {
        string subtitle = string.Empty;
        public string Subtitle
        {
            get { return subtitle; }
            set { SetProperty(ref subtitle, value); }
        }

        public MainPageViewModels()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;
        }
    }
}
