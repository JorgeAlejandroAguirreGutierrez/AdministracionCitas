using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Programacion
    {
        private int idprogramacion;
        private int idcurso;
        private string actividad;
        private string ubicacion;

        public Programacion(int idprogramacion, int idcurso, string actividad, string ubicacion)
        {
            this.idprogramacion = idprogramacion;
            this.idcurso = idcurso;
            this.actividad = actividad;
            this.ubicacion = ubicacion;
        }

        public int getSetIdprogramacion
        {
            get
            {
                return idprogramacion;
            }
            set
            {
                idprogramacion = value;
            }
        }
        public int getSetIdcurso
        {
            get
            {
                return idcurso;
            }
            set
            {
                idcurso = value;
            }
        }

        public string getSetActividad
        {
            get
            {
                return actividad;
            }
            set
            {
                actividad = value;
            }
        }

        public string getSetUbicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                ubicacion = value;
            }
        }

        
    }
}