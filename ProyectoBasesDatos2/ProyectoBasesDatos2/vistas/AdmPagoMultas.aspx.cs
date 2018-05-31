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
    public partial class AdmPagoMultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<PagoMulta> pagomultas = Default.controladora.mostrarPagoMultas();
            foreach (PagoMulta i in pagomultas)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell();
                td1.InnerText = i.getSetIdpago.ToString();
                HtmlTableCell td2 = new HtmlTableCell();
                td2.InnerText = i.getSetIdmulta.ToString();
                HtmlTableCell td3 = new HtmlTableCell();
                td3.InnerText = i.getSetFecha;
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tabla1.Controls.Add(tr);
            }
        }
    }
}