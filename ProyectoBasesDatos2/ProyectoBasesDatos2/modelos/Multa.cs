using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Multa
    {
        private int idmulta;
        private int idcita;
        private string descripcion;
        private string fecha;
        private int valor;

        public Multa(int idmulta, int idcita, string descripcion, string fecha, int valor)
        {
            this.idmulta = idmulta;
            this.idcita = idcita;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.valor=valor;
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
        public int getSetIdcita
        {
            get
            {
                return idcita;
            }
            set
            {
                idcita = value;
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
        public int getSetValor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
    }
}