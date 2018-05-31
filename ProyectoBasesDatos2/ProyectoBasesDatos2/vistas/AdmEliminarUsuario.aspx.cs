using ProyectoBasesDatos2.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoBasesDatos2.vistas
{
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Default.controladora.getSetCedula = TextBox1.Text;
            UsuarioUser i = Default.controladora.buscarUsuario(Default.controladora.getSetCedula);
            HtmlTableRow tr = new HtmlTableRow();
            HtmlTableCell td1 = new HtmlTableCell();
            td1.InnerText = i.getSetIdusuario.ToString();
            HtmlTableCell td2 = new HtmlTableCell();
            td2.InnerText = i.getSetRol;
            HtmlTableCell td3 = new HtmlTableCell();
            td3.InnerText = i.getSetCategoria;
            HtmlTableCell td4 = new HtmlTableCell();
            td4.InnerText = i.getSetNombre;
            HtmlTableCell td5 = new HtmlTableCell();
            td5.InnerText = i.getSetCedula;
            HtmlTableCell td6 = new HtmlTableCell();
            td6.InnerText = i.getSetCorreo;
            HtmlTableCell td7 = new HtmlTableCell();
            td7.InnerText = i.getSetActivo;
            HtmlTableCell td8 = new HtmlTableCell();
            td8.InnerText = i.getSetIncumplimiento.ToString();
            tr.Controls.Add(td1);
            tr.Controls.Add(td2);
            tr.Controls.Add(td3);
            tr.Controls.Add(td4);
            tr.Controls.Add(td5);
            tr.Controls.Add(td6);
            tr.Controls.Add(td7);
            tr.Controls.Add(td8);
            tabla1.Controls.Add(tr);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int retorno = Default.controladora.eliminarUsuario(Default.controladora.getSetCedula);
            if (retorno==1)
            {
                Response.Redirect("AdmPrincipal.aspx");
            }
        }
    }
}