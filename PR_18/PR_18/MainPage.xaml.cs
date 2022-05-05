using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PR_18
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            NumbersFactsPage viewModel = new NumbersFactsPage();
            this.BindingContext = viewModel;
        }
    }
}
