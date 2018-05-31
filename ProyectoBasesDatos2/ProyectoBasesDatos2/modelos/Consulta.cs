using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Consulta
    {
        private int idconsulta;
        private int idusuario;
        private string descripcion;
        private string respuesta;


        public Consulta(int idconsulta, int idusuario, string descripcion, string respuesta)
        {
            this.idconsulta = idconsulta;
            this.idusuario=idusuario;
            this.descripcion = descripcion;
            this.respuesta = respuesta;
        }

        public int getSetIdconsulta
        {
            get
            {
                return idconsulta;
            }
            set
            {
                idconsulta = value;
            }
        }
        public int getSetIdusuario
        {
            get
            {
                return idusuario;
            }
            set
            {
                idusuario = value;
            }
        }
        public string getSetDescripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        public string getSetRespuesta
        {
            get
            {
                return respuesta;
            }
            set
            {
                respuesta = value;
            }
        }
    }
}