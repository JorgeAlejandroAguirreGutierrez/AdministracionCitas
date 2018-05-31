using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBasesDatos2.modelos
{
    public class Usuario
    {
        private int idusuario;
        private string rol;
        private string categoria;
        private string nombre;
        private string cedula;
        private string correo;
        private string activo;
        private int incumplimiento;

        public Usuario(int idusuario, string rol, string categoria, string nombre, string cedula, string correo, string activo, int incumplimiento)
        {
            this.idusuario = idusuario;
            this.rol = rol;
            this.categoria = categoria;
            this.nombre = nombre;
            this.cedula = cedula;
            this.correo = correo;
            this.activo = activo;
            this.incumplimiento = incumplimiento;
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

        public string getSetRol
        {
            get
            {
                return rol;
            }
            set
            {
                rol = value;
            }
        }

        public string getSetCategoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        public string getSetNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string getSetCedula
        {
            get
            {
                return cedula;
            }
            set
            {
                cedula = value;
            }
        }

        public string getSetCorreo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }

        public string getSetActivo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }

        public int getSetIncumplimiento
        {
            get
            {
                return incumplimiento;
            }
            set
            {
                incumplimiento = value;
            }
        }
    }
}