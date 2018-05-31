﻿using ProyectoBasesDatos2.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoBasesDatos2.vistas
{
    public partial class AdmMultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Multa> multas = Default.controladora.mostrarMultas();
            foreach (Multa i in multas)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell();
                td1.InnerText = i.getSetIdmulta.ToString();
                HtmlTableCell td2 = new HtmlTableCell();
                td2.InnerText = i.getSetIdcita.ToString();
                HtmlTableCell td3 = new HtmlTableCell();
                td3.InnerText = i.getSetDescripcion;
                HtmlTableCell td4 = new HtmlTableCell();
                td4.InnerText = i.getSetFecha;
                HtmlTableCell td5 = new HtmlTableCell();
                td5.InnerText = i.getSetValor.ToString();
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);
                tr.Controls.Add(td5);
                tabla1.Controls.Add(tr);
            }
        }
    }
}