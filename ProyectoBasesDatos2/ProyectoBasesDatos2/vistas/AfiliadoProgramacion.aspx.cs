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
    public partial class AfiliadoProgramacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idusuario = Default.controladora.getSetU.getSetIdentificacion;
            List<Programacion> programaciones = Default.controladora.MostrarProgramacion(idusuario);
            foreach (Programacion i in programaciones)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell();
                td1.InnerText = i.getSetIdprogramacion.ToString();
                HtmlTableCell td2 = new HtmlTableCell();
                td2.InnerText = i.getSetIdcurso.ToString();
                HtmlTableCell td3 = new HtmlTableCell();
                td3.InnerText = i.getSetActividad;
                HtmlTableCell td4 = new HtmlTableCell();
                td4.InnerText = i.getSetUbicacion;
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);
                tabla1.Controls.Add(tr);
            }
        }
    }
}