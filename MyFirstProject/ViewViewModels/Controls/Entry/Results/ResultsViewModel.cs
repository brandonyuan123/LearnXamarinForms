using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Entry.Results
{
    class ResultsViewModel : BaseViewModel
    {
        public ResultsViewModel()
        {
            Title = Titles.ResultsTitle;
        }
    }
}
