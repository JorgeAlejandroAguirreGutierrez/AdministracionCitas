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
    public partial class AfiliadoPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Curso> cursos = Default.controladora.mostrarCursos();
            foreach (Curso i in cursos)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell();
                td1.InnerText = i.getSetIdcurso.ToString();
                HtmlTableCell td2 = new HtmlTableCell();
                td2.InnerText = i.getSetTitulo;
                HtmlTableCell td3 = new HtmlTableCell();
                td3.InnerText = i.getSetDescripcion;
                HtmlTableCell td4 = new HtmlTableCell();
                td4.InnerText = i.getSetDuracion.ToString();
                HtmlTableCell td5 = new HtmlTableCell();
                td5.InnerText = i.getSetFechainicio;
                HtmlTableCell td6 = new HtmlTableCell();
                td6.InnerText = i.getSetFechafin;
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                tr.Controls.Add(td3);
                tr.Controls.Add(td4);
                tr.Controls.Add(td5);
                tr.Controls.Add(td6);
                tabla1.Controls.Add(tr);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idcurso = Convert.ToInt32(TextBox1.Text);
            int idusuario = Default.controladora.getSetU.getSetIdentificacion;
            int retorno=Default.controladora.registrarCurso(idcurso,idusuario);
            if (retorno==1)
            {
                Response.Redirect("AfiliadoProgramacion.aspx");
            }
        }
    }
}