using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3JParraga
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void btnSumar2_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                double Seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
                double Examen2 = Convert.ToDouble(txtExamen2.Text);
                Seguimiento2 = Seguimiento2 * 0.3;
                Examen2 = Examen2 * 0.2;
                double suma = Seguimiento2 + Examen2;
                txtResultado2.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "ok");
            }
        }
        void btnSumar1_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                double Seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
                double Examen1 = Convert.ToDouble(txtExamen1.Text);
                Seguimiento1 = Seguimiento1 * 0.3;
                Examen1 = Examen1 * 0.2;
                double suma = Seguimiento1 + Examen1;
                txtResultado1.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "ok");
            }
        }
        void btnSumarTotal_Clicked(System.Object sender, System.EventArgs e)
        {

            double Resultado1 = Convert.ToDouble(txtResultado1.Text);
            double Resultado2 = Convert.ToDouble(txtResultado2.Text);
            double ResultadoFinal = Resultado1 + Resultado2;
            if (ResultadoFinal >= 7)
                DisplayAlert("Mensaje de alerta", "La nota es: " + ResultadoFinal + " y está Aprobado", "Cerrar");
            else
                DisplayAlert("Mensaje de alerta", "La nota es: " + ResultadoFinal + " y está Reprobado", "Cerrar");

        }
    }
}