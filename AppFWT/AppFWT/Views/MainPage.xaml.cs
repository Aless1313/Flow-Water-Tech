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
using AppFWT.Clases;

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

        public async void Registrar()
        {
            try
            {
                UserManager manager = new UserManager();
                manager.registrar(txt_user.Text.ToString(),txt_mailregister.Text.ToString(),txt_passwordregister.Text.ToString());
                await this.DisplayAlert("Exito", "Registrado", "Aceptar");
                stkregistrar.IsVisible = false;
                ButtonsLogin.IsVisible = true;
            }
            catch(Exception e)
            {
                await this.DisplayAlert("Error", e.Message,"Aceptar");
            }
        }
        public async void VerificarRegistro()
        {
            if (String.IsNullOrWhiteSpace(txt_mailregister.Text))
            {
                await this.DisplayAlert("Error", "Campo email vacio", "Aceptar");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txt_passwordregister.Text))
                {
                    await this.DisplayAlert("Error", "Campo contraseña vacio", "Aceptar");
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(txt_user.Text))
                    {
                        await this.DisplayAlert("Error","Campo usuario vacio","Aceptar");
                    }
                    else
                    {
                        Registrar();
                    }
                }
            }
        } 
        
        private void btn_registrar_Clicked(object sender, EventArgs e)
        {
            //Registrar
            VerificarRegistro();
        }

        private void btn_regresarregister_Clicked(object sender, EventArgs e)
        {
            if(stkregistrar.IsVisible == true)
            {
                stkregistrar.IsVisible = false;
                ButtonsLogin.IsVisible = true;
            }
        }

        public async void AbrirMenu()
        {
            await Navigation.PushAsync(new dashboard("hola"));
        }
        public async void VerificarExiste()
        {
            try
            {
                UserManager manager = new UserManager();
                var result = await manager.Login(txt_mailsesion.Text.ToString(), txt_passwordsesion.Text.ToString());
                if (result.Count() > 0)
                {
                    AbrirMenu();
                }
                else
                {
                    await this.DisplayAlert("Error", "Usuario o Contraseña incorrectas", "Aceptar");
                }   
            }
            catch(Exception ex)
            {
                await this.DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
        public async void VerificarSesion()
        {
            if (String.IsNullOrWhiteSpace(txt_mailsesion.Text))
            {
                await this.DisplayAlert("Error", "Campo email vacio", "Aceptar");
            }
            else
            {
                if(String.IsNullOrWhiteSpace(txt_passwordsesion.Text))
                {
                    await this.DisplayAlert("Error", "Campo contraseña vacio", "Aceptar");
                }
                else
                {
                    VerificarExiste();
                }
            }
        }
        private void btn_iniciarsesion_Clicked(object sender, EventArgs e)
        {
            //Iniciar sesion
            VerificarSesion();
            //Navigation.PushAsync(new Escaner());
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
