using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFWT
{
    public partial class App : Application
    {
        public App()
        {
            //Licencia de Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzk1MTAyQDMxMzgyZTM0MmUzMGwzTGU2bDdwVEd3UmpZY3lYVjYrVGl2R2FvNU56R0tTaXBsVlNsUjQwN2M9");
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
