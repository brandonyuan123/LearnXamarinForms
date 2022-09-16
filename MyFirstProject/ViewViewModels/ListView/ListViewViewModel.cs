using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.ListView
{
    public class ListViewViewModel : BaseViewModel
    {
        public ListViewViewModel()
        {
            Title = Titles.ListViewTitle;
        }
    }
}
