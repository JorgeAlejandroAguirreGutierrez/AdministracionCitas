using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class PagoCopago
    {
        private int idpagocopago;
        private int idcopago;
        private string fecha;

        public PagoCopago(int idpagocopago, int idcopago, string fecha)
        {
            this.idpagocopago = idpagocopago;
            this.idcopago = idcopago;
            this.fecha = fecha;
        }

        public int getSetIdpagocopago
        {
            get
            {
                return idpagocopago;
            }
            set
            {
                idpagocopago = value;
            }
        }

        public int getSetIdcopago
        {
            get
            {
                return idcopago;
            }
            set
            {
                idcopago = value;
            }
        }

        public string getSetFecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
    }
}