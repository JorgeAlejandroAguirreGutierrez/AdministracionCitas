using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using ProyectoBasesDatos2.modelos;

namespace ProyectoBasesDatos2.vistas
{
    public partial class AdmPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<UsuarioUser> usuarios=Default.controladora.mostrarUsuarios();
            foreach(UsuarioUser i in usuarios)
            {
                HtmlTableRow tr= new HtmlTableRow();
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
        }
    }
}