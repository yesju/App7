using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formulario : ContentPage
    {
        public formulario()
        {
            InitializeComponent();
            
        }
        private void guardar_Clicked(object sender, EventArgs e)
        {

          DisplayAlert("Datos Ingresados", "Hola \n" + Nombre.Text + "\n" + Apellidos.Text + "" + Direccion.Text + "\n" + Telefono.Text + "\n" + Carrera.Text + "\n" + Semestre.Text + "\n" + Matricula.Text + "\n" + Correo.Text + "\n" + GitHub.Text, "OK");
            Navigation.PushAsync(new Calculadora());
        }
    }
}