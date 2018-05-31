using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Curso
    {
        private int idcurso;
        private string titulo;
        private string descripcion;
        private int duracion;
        private string fechainicio;
        private string fechafin;


        public Curso(int idcurso, string titulo, string descripcion, int duracion, string fechainicio, string fechafin)
        {
            this.idcurso = idcurso;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.duracion = duracion;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
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
        public string getSetTitulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
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

        public int getSetDuracion
        {
            get
            {
                return duracion;
            }
            set
            {
                duracion = value;
            }
        }

        public string getSetFechainicio
        {
            get
            {
                return fechainicio;
            }
            set
            {
                fechainicio = value;
            }
        }

        public string getSetFechafin
        {
            get
            {
                return fechafin;
            }
            set
            {
                fechafin = value;
            }
        }
    }
}