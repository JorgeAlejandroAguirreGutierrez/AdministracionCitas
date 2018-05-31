using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Categoria
    {
        private int idcategoria;
        private string tipo;


        public Categoria(int idcategoria, string tipo)
        {
            this.idcategoria = idcategoria;
            this.tipo = tipo;
        }

        public int getSetIdcategoria
        {
            get
            {
                return idcategoria;
            }
            set
            {
                idcategoria = value;
            }
        }

        public string getSetTipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
    }
}