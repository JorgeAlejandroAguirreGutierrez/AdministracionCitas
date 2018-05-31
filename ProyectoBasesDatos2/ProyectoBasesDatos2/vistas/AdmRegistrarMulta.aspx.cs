using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoBasesDatos2.vistas
{
    public partial class AdmRegistrarMulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idcita=Convert.ToInt32(TextBox1.Text);
            string descripcion=TextBox2.Text;
            string fecha=Calendar1.SelectedDate.ToShortDateString();
            int valor = Convert.ToInt32(TextBox3.Text);
            int retorno = Default.controladora.registrarMulta(idcita, descripcion, fecha, valor);
            if (retorno==1)
            {
                Response.Redirect("AdmMultas.aspx");
            }
        }
    }
}