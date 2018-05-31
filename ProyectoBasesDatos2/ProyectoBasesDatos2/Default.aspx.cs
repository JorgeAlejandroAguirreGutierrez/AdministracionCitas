using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoBasesDatos2.controladoras;
using ProyectoBasesDatos2.vistas;
using ProyectoBasesDatos2.modelos;

namespace ProyectoBasesDatos2
{
    public partial class Default : System.Web.UI.Page
    {
        public static Controladora controladora;
        protected void Page_Load(object sender, EventArgs e)
        {
            controladora = new Controladora();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string correo=TextBox1.Text;
            string contrasena=TextBox2.Text;
            IniciarSesion u=controladora.iniciarSesion(correo, contrasena);
            TextBox2.Text = u.getSetIdentificacion.ToString();
            if (u!=null)
            {
                controladora.getSetU = u;
                if (u.getSetRol == "ADMINISTRADOR")
                {
                    
                    Response.Redirect("vistas/AdmPrincipal.aspx");
                }
                else if (u.getSetRol == "AFILIADO")
                {
                    Response.Redirect("vistas/AfiliadoPrincipal.aspx");
                    
                }
                else
                {
                    controladora.getSetIdmedico = controladora.obtenerIdmedico(u.getSetIdentificacion);
                    Response.Redirect("vistas/MedicoPrincipal.aspx");
                }
                
                
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            
        }
        
        

        //Para redirigir a otra pagina en c# se utiliza:
        //Response.Redirect("vistas/AdmEspecialidad.aspx");

        //Para los botones utilizamos como parametros:
        //protected void Button1_Click(object sender, EventArgs e)
        

    }
}