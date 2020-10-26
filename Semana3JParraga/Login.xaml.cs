using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Semana3JParraga
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

      private async void btnIngresar_Clicked(System.Object sender, System.EventArgs e)
        {
            if(!txtUsuario.Text.Equals("estudiante2020")&& !txtClave.Text.Equals("uisrael2020")){
                DisplayAlert("Alerta!", "El usuario y contraseña son incorrectos", "Cerrar");
            }
            else { 
            if (!txtUsuario.Text.Equals("estudiante2020"))
            {
                DisplayAlert("Alerta!", "El usuario es incorrecto", "Cerrar");
            }
            else
            {
                    if (!txtClave.Text.Equals("uisrael2020"))
                    {
                        DisplayAlert("Alerta!", "La contraseña es incorrecta", "Cerrar");
                    }
                    else {
                        await Navigation.PushAsync(new MainPage());
                    }

            }
            }
            
        }

    }
}
