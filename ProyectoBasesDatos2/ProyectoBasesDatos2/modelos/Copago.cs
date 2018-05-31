using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Copago
    {
        private int idcopago;
        private int idcita;
        private string fecha;
        private int valor;


        public Copago(int idcopago, int idcita, string fecha, int valor)
        {
            this.idcopago = idcopago;
            this.idcita = idcita;
            this.fecha = fecha;
            this.valor = valor;
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