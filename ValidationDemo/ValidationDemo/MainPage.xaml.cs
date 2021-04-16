using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValidationDemo
{
    public partial class MainPage : ContentPage
    {
        private bool _emailValid;

        public bool EmailValid
        {
            get => _emailValid;
            set
            {
                _emailValid = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
