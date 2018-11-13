using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _texto;

        public string Texto
        {
            get { return _texto; }
            set { _texto = value; OnPropertyChanged(); }
        }

        public MainPageViewModel()
        {
            Texto = "OOOOI";
        }
    }
}
