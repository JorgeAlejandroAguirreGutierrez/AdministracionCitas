using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Atencion
    {
        private int idatencion;
        private string tipo;

        public Atencion(int idatencion, string tipo)
        {
            this.idatencion = idatencion;
            this.tipo = tipo;
        }

        public int getSetIdatencion
        {
            get
            {
                return idatencion;
            }
            set
            {
                idatencion = value;
            }
        }

        public string getSetTipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

    }
}