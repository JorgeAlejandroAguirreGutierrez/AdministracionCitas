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
    public partial class MedicoPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Agenda> agendas = Default.controladora.mostrarAgenda();
            foreach (Agenda i in agendas)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell();
                td1.InnerText = i.getSetIdagenda.ToString();
                HtmlTableCell td2 = new HtmlTableCell();
                td2.InnerText = i.getSetFecha;
                HtmlTableCell td3 = new HtmlTableCell();
                td3.InnerText = i.getSetHora.ToString();
                HtmlTableCell td4 = new HtmlTableCell();
                td4.InnerText = i.getSetDisponible;
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);
                tabla1.Controls.Add(tr);
            }
        }
    }
}