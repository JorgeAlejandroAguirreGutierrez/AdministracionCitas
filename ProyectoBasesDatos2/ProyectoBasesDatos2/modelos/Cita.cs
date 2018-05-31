using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Cita
    {
        private int idcita;
        private int idatencion;
        private int idmedico;
        private int idusuario;
        private int idagenda;
        private string estado;


        Cita(int idcita, int idatencion, int idmedico, int idusuario, int idagenda, string estado)
        {
            this.idcita = idcita;
            this.idatencion = idatencion;
            this.idmedico = idmedico;
            this.idusuario = idusuario;
            this.idagenda = idagenda;
            this.estado = estado;
        }


        public int getSetIdcita
        {
            get
            {
                return idcita;
            }
            set
            {
                idcita= value;
            }
        }

        public int getSetIdatención
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

        public int getSetIdmedico
        {
            get
            {
                return idmedico;
            }
            set
            {
                idmedico = value;
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

        public int getSetIdagenda
        {
            get
            {
                return idagenda;
            }
            set
            {
                idagenda = value;
            }
        }

        public string getSetEstado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
    }
}