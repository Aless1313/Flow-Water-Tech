using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFWT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Escaner : ContentPage
    {
        public Escaner()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void Scanner()
        {
            var scannerPage = new ZXingScannerPage();
            scannerPage.Title = "Escaneando código";
            
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = true;
               
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await this.DisplayAlert("Escaneado", result.Text,  "OK");
                    await Navigation.PushAsync(new dashboard(result.Text));

                });
            };
            await Navigation.PushAsync(scannerPage);
        }
 

        private void btn_escanear_Clicked(object sender, EventArgs e)
        {
            Scanner();
        }
    }
}