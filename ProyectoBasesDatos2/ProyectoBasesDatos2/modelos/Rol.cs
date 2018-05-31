using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Rol
    {
        int idrol;
        string tipo;

        public Rol(int idrol, string tipo)
        {
            this.idrol = idrol;
            this.tipo = tipo;
        }

        public int getSetIdrol
        {
            get
            {
                return idrol;
            }
            set
            {
                idrol = value;
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