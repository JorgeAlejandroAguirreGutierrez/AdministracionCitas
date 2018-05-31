using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoBasesDatos2.vistas
{
    public partial class AdmRegistrarPagoCopago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idcopago = Convert.ToInt32(TextBox1.Text);
            string fecha = Calendar1.SelectedDate.ToShortDateString();
            //ACA VAN AVER PROBLEMAS CON LOS TIPOS DE DATOS DATE
            int retorno = Default.controladora.registrarPagoCopago(idcopago, fecha);
            if (retorno == 1)
            {
                Response.Redirect("AdmPagoCopagos.aspx");
            }
        }
    }
}