using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoBasesDatos2.modelos;

namespace ProyectoBasesDatos2.vistas
{
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Rol>roles=Default.controladora.mostrarRoles();
            foreach (Rol i in roles)
            {
                ListItem item= new ListItem(i.getSetTipo,i.getSetIdrol.ToString());
                DropDownList1.Items.Add(item);

            }

            List<Categoria> categorias = Default.controladora.mostrarCategorias();
            foreach (Categoria i in categorias)
            {
                ListItem item = new ListItem(i.getSetTipo, i.getSetIdcategoria.ToString());
                DropDownList2.Items.Add(item);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idrol = Convert.ToInt32(DropDownList1.SelectedValue);
            int idcategoria = Convert.ToInt32(DropDownList2.SelectedValue);
            string nombre = TextBox1.Text;
            string cedula = TextBox2.Text;
            string contrasena = TextBox3.Text;
            string correo = TextBox4.Text;
            int retorno = Default.controladora.registrarUsuario(idrol, idcategoria, nombre, cedula, contrasena, correo);
            if (retorno==1)
            {
                Response.Redirect("AdmPrincipal.aspx");
            }
        }
    }
}