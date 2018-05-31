using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Especialidad
    {
        private int idespecialidad;
        private string tipo;

        public Especialidad(int idespecialidad, string tipo)
        {
            this.idespecialidad = idespecialidad;
            this.tipo = tipo;
        }
        
        public int getSetIdespecialidad
        {
            get
            {
                return idespecialidad;
            }
            set
            {
                idespecialidad = value;
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