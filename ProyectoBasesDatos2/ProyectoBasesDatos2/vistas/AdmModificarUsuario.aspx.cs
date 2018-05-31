using ProyectoBasesDatos2.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoBasesDatos2.vistas
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cedula = TextBox1.Text;
            UsuarioUser usuario=Default.controladora.buscarUsuario(cedula);
            TextBox2.Text = usuario.getSetRol;
            TextBox3.Text = usuario.getSetCategoria;
            TextBox4.Text = usuario.getSetNombre;
            TextBox5.Text = usuario.getSetCedula;
            TextBox6.Text = usuario.getSetCorreo;
            TextBox7.Text = usuario.getSetIncumplimiento.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}