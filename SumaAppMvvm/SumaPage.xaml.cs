using SumaAppMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.Views
{
    public partial class SumaPage : ContentPage
    {
        public SumaViewModel ViewModel { get; set; }

        public SumaPage()
        {
            InitializeComponent();
            ViewModel = new SumaViewModel();
            BindingContext = ViewModel;
        }

        private void SumarClicked(object sender, System.EventArgs e)
        {
            ViewModel.SumarCommand.Execute(null);
        }

        private void LimpiarClicked(object sender, System.EventArgs e)
        {
            ViewModel.LimpiarCommand.Execute(null);
        }
    }
}