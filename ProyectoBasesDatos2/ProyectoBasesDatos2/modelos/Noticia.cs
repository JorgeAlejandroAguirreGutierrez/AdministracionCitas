using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Noticia
    {
        private int idnoticia;
        private string titulo;
        private string descripcion;
        private string fecha;
        private string ubicacion;

        public Noticia(int idnoticia, string titulo, string descripcion, string fecha, string ubicacion)
        {
            this.idnoticia = idnoticia;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.ubicacion = ubicacion;
        }

        public int getSetIdnoticia
        {
            get
            {
                return idnoticia;
            }
            set
            {
                idnoticia = value;
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