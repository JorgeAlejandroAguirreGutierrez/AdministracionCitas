using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class CitaUser
    {
        private int idcita;
        private string tipoatencion;
        private string nombreusuario;
        private string fecha;
        private int hora;

        public CitaUser(int idcita, string tipoatencion, string nombreusuario, string fecha, int hora)
        {
            this.idcita = idcita;
            this.tipoatencion = tipoatencion;
            this.nombreusuario = nombreusuario;
            this.fecha = fecha;
            this.hora = hora;
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

        public string getSetTipoatencion
        {
            get
            {
                return tipoatencion;
            }
            set
            {
                 tipoatencion = value;
            }
        }

        public string getSetNombreusuario
        {
            get
            {
                return nombreusuario;
            }
            set
            {
                nombreusuario = value;
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

        public int getSetHora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }
    }
}