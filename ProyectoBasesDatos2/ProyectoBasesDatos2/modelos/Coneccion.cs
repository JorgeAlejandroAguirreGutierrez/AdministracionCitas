using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ProyectoBasesDatos2.modelos
{
    public class Coneccion
    {
        OracleConnection coneccionnueva;
        OracleCommand cmd; //Para hacer las demas operaciones
        OracleDataReader leer; //Para hacer consultas

        public Coneccion()
        {
            this.coneccionnueva = new OracleConnection("User Id=BASES2;Password=BASES2;Data Source=;");
            this.coneccionnueva.Open();
            this.cmd = null;
            leer = null;
        }

        public OracleDataReader getSetLeer
        {
            get
            {
                return leer;
            }
            set
            {
                leer = value;
            }
        }

        public OracleConnection getSetConeccion
        {
            get{
                return coneccionnueva;
            }
            set{
                coneccionnueva = value;
            }
        }

        public OracleCommand getSetComando
        {
            get
            {
                return this.cmd;
            }
            set
            {
                this.cmd = value;
            }
        }
    }
}