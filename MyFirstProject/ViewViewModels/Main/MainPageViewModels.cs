using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Main
{
    public class MainPageViewModels : BaseViewModel
    {
        public MainPageViewModels()
        {
            Title = Titles.MainPageTitle;
        }
    }
}
