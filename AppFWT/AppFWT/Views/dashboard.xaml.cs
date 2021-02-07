using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFWT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dashboard : ContentPage
    {
        public dashboard(string qr)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Victor se la come toda JAJAJAJAxdd
            //Asi es
        }
    }
}