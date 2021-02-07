using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.XForms.MaskedEdit;
using Syncfusion.XForms.Buttons;
using Border = Syncfusion.XForms.Border.SfBorder;
using System.Collections.ObjectModel;
using AppFWT.Views;

namespace AppFWT
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<View> viewCollection = new ObservableCollection<View>();
        
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            ButtonsLogin.VerticalOptions = LayoutOptions.EndAndExpand;
            stkiniciar.IsVisible = false;
            stkregistrar.IsVisible = false;

            
        }


        private void btn_opcioniniciarsesion_Clicked(object sender, EventArgs e)
        {
            if(stkiniciar.IsVisible == false)
            {
                stkiniciar.IsVisible = true;
                ButtonsLogin.IsVisible = false;
            }
        }

        private void btn_opcionregistrar_Clicked(object sender, EventArgs e)
        {
            if(stkregistrar.IsVisible == false)
            {
                stkregistrar.IsVisible = true;
                ButtonsLogin.IsVisible = false;
                
            }
        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {
            //Registrar
        }

        private void btn_regresarregister_Clicked(object sender, EventArgs e)
        {
            if(stkregistrar.IsVisible == true)
            {
                stkregistrar.IsVisible = false;
                ButtonsLogin.IsVisible = true;
            }
        }

        private void btn_iniciarsesion_Clicked(object sender, EventArgs e)
        {
            //Iniciar sesion
            //Navigation.PushAsync(new Escaner());
            Navigation.PushAsync(new dashboard("hola"));
        }

        private void btn_regresarsesion_Clicked(object sender, EventArgs e)
        {
            if(stkiniciar.IsVisible == true)
            {
                stkiniciar.IsVisible = false;
                ButtonsLogin.IsVisible = true;
            }
        }
    }
}
