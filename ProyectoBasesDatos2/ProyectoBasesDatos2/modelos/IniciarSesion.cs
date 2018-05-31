using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class IniciarSesion
    {
        private int identificacion;
        private string rol;

        public IniciarSesion(int identificacion, string rol)
        {
            this.identificacion = identificacion;
            this.rol = rol;
        }

        public int getSetIdentificacion
        {
            get
            {
                return identificacion;
            }
            set
            {
                identificacion = value;
            }
        }

        public string getSetRol
        {
            get
            {
                return rol;
            }
            set
            {
                rol = value;
            }
        }
    }
}