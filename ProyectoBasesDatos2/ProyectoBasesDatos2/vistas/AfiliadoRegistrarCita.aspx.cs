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
    public partial class AfiliadoRegistrarCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Atencion> atenciones = Default.controladora.mostrarAtencion();
            
            foreach (Atencion i in atenciones)
            {
                ListItem item = new ListItem(i.getSetTipo, i.getSetIdatencion.ToString());
                DropDownList1.Items.Add(item);
            }
            List<Agenda> agendas = Default.controladora.mostrarAgendaAfiliado();
            foreach (Agenda i in agendas)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell();
                td1.InnerText = i.getSetIdagenda.ToString();
                HtmlTableCell td2 = new HtmlTableCell();
                td2.InnerText = i.getSetMedico;
                HtmlTableCell td3 = new HtmlTableCell();
                td3.InnerText = i.getSetFecha;
                HtmlTableCell td4 = new HtmlTableCell();
                td4.InnerText = i.getSetHora.ToString();
                HtmlTableCell td5 = new HtmlTableCell();
                td5.InnerText = i.getSetEspecialidad;
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);
                tr.Controls.Add(td5);
                tabla1.Controls.Add(tr);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idagenda = Convert.ToInt32(TextBox1.Text);
            int idatencion=Convert.ToInt32(DropDownList1.SelectedValue);
            int idusuario=Default.controladora.getSetU.getSetIdentificacion;
            int retorno = Default.controladora.registrarCita(idatencion, idusuario, idagenda);
            if(retorno==1)
            {
                Response.Redirect("AfiliadoCita.aspx");
            }
        }
    }
}