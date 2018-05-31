using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class PagoMulta
    {
        private int idpago;
        private int idmulta;
        private string fecha;

        public PagoMulta(int idpago, int idmulta, string fecha)
        {
            this.idpago = idpago;
            this.idmulta = idmulta;
            this.fecha = fecha;
        }

        public int getSetIdpago
        {
            get
            {
                return idpago;
            }
            set
            {
                idpago = value;
            }
        }

        public int getSetIdmulta
        {
            get
            {
                return idmulta;
            }
            set
            {
                idmulta = value;
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