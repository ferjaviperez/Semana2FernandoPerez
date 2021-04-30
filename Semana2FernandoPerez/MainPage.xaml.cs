using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana2FernandoPerez
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string clave)
        {
            InitializeComponent();
        }
        private void btnSumar_Clicked(object sender, EventArgs e)
        {
         
            try
            {

                double dato1 = Convert.ToDouble(txts1.Text);
                double dato2 = Convert.ToDouble(txte1.Text);
                double dato3 = Convert.ToDouble(txts2.Text);
                double dato4 = Convert.ToDouble(txte2.Text);

                double suma = ((dato1 * 0.3) + (dato2 * 0.2)) + ((dato3 * 0.3) + (dato4 * 0.2));
                
                txtpromedio.Text = suma.ToString()+ " Su Promedio";

                if (suma >= 7)
                {
                    DisplayAlert("Mensaje", "APROBADO", "Cerrar");
                }
                else if (suma >= 5)
                {
                    DisplayAlert("Mensaje", "COMPLEMENTARIO", "Cerrar");
                }
                else if (suma < 5)
                {
                    DisplayAlert("Mensaje", "REROBADO", "Cerrar");
                }



            }
            catch (Exception ex)
            {
                //Mensaje de erro capturado por el catch
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }

        }
    }
}
