using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoBasesDatos2.vistas
{
    public partial class MedicoRegistrarAgenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fecha = Calendar1.SelectedDate.ToShortDateString();
            int hora = Convert.ToInt32(TextBox2.Text);
            int retorno = Default.controladora.registrarAgenda(fecha, hora);
            if (retorno==1)
            {
                Response.Redirect("MedicoPrincipal.aspx");
            }
        }
    }
}