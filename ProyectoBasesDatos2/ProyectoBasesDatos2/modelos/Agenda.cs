using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Agenda
    {
        private int idagenda;
        private int idmedico;
        private string medico;
        private string fecha;
        private int hora;
        private string disponible;
        private string especialidad;


        public Agenda(int idagenda, int idmedico, string fecha, int hora, string disponible)
        {
            this.idagenda = idagenda;
            this.idmedico = idmedico;
            this.fecha = fecha;
            this.hora = hora;
            this.disponible = disponible;
        }

        public Agenda(int idagenda, int idmedico, string medico, string fecha, int hora, string especialidad, string disponible)
        {
            this.idagenda = idagenda;
            this.idmedico = idmedico;
            this.medico = medico;
            this.fecha = fecha;
            this.hora = hora;
            this.especialidad = especialidad;
            this.disponible = disponible;
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

        public string getSetMedico
        {
            get
            {
                return medico;
            }
            set
            {
                medico = value;
            }
        }

        public string getSetEspecialidad
        {
            get
            {
                return especialidad;
            }
            set
            {
                especialidad = value;
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

        public string getSetDisponible
        {
            get
            {
                return disponible;
            }
            set
            {
                disponible = value;
            }
        }
    }
}