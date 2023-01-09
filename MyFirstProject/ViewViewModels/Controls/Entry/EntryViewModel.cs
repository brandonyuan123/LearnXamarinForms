using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MyFirstProject.ViewViewModels.Controls.Entry
{
    class EntryViewModel:BaseViewModel
    {
        public ICommand OnEntryClicked { get; }

        private string _entryText = string.Empty;
    }
}
