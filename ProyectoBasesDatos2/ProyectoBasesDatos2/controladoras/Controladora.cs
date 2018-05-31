using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoBasesDatos2.modelos;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace ProyectoBasesDatos2.controladoras
{
    public class Controladora
    {
        Coneccion oracle;
        private IniciarSesion u;
        private string cedula;
        private int idmedico;

        public Controladora()
        {
            oracle = new Coneccion();
            u = null;
            idmedico = -2;
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

        public IniciarSesion getSetU
        {
            get
            {
                return u;
            }
            set
            {
                u = value;
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

        
        //PAQUETE DE USUARIOS

        public IniciarSesion iniciarSesion(string correo, string contrasena)
        {
            IniciarSesion u = null;
            try
            {
                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.INICIAR_SESION", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("CORREO", OracleDbType.Varchar2,200, correo, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("CONTRASENA", OracleDbType.Varchar2, 45, contrasena, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("IDENTIFICACION", OracleDbType.Int32,null, ParameterDirection.Output);
                oracle.getSetComando.Parameters.Add("TIPOROL", OracleDbType.Varchar2, 45, null, ParameterDirection.Output);
                oracle.getSetComando.ExecuteNonQuery();
                int identificacion = Convert.ToInt32(oracle.getSetComando.Parameters["IDENTIFICACION"].Value.ToString());
                string rol = oracle.getSetComando.Parameters["TIPOROL"].Value.ToString();
                u = new IniciarSesion(identificacion, rol);
                return u;
            }
            catch
            {
                return u;
            }
        }

        public List<UsuarioUser> mostrarUsuarios()
        {
            List<UsuarioUser> usuarios = new List<UsuarioUser>();
            try
            {
                
                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.MOSTRAR_USUARIOS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                //oracle.getSetComando.ExecuteNonQuery();
                oracle.getSetLeer=oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idusuario = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string rol = oracle.getSetLeer.GetValue(1).ToString();
                    string categoria = oracle.getSetLeer.GetValue(2).ToString();
                    string nombre = oracle.getSetLeer.GetValue(3).ToString();
                    string cedula = oracle.getSetLeer.GetValue(4).ToString();
                    string correo = oracle.getSetLeer.GetValue(5).ToString();
                    string activo = oracle.getSetLeer.GetValue(6).ToString();
                    int incumplimiento = Convert.ToInt32(oracle.getSetLeer.GetValue(7));
                    UsuarioUser u = new UsuarioUser(idusuario, rol, categoria, nombre, cedula, correo, activo, incumplimiento);
                    usuarios.Add(u);
                }
                return usuarios;
                
            }
            catch
            {
                return usuarios;
            }
        }
        
        public List<Rol> mostrarRoles()
        {
            List<Rol> roles = new List<Rol>();
            try
            {

                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.MOSTRAR_ROLES", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                //oracle.getSetComando.ExecuteNonQuery();
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idrol = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string tipo = oracle.getSetLeer.GetValue(1).ToString();
                    Rol r = new Rol(idrol, tipo);
                    roles.Add(r);
                }
                return roles;

            }
            catch
            {
                return roles;
            }
        }

        public List<Categoria> mostrarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            try
            {

                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.MOSTRAR_CATEGORIAS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idcategoria = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string tipo = oracle.getSetLeer.GetValue(1).ToString();
                    Categoria c = new Categoria(idcategoria, tipo);
                    categorias.Add(c);
                }
                return categorias;

            }
            catch
            {
                return categorias;
            }
        }

        public int registrarUsuario(int idrol, int idcategoria, string nombre, string cedula, string contrasena, string correo)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.REGISTRAR_USUARIO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("ROL", OracleDbType.Int32, idrol, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("CATEGORIA", OracleDbType.Int32, idcategoria, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("NOMBRE", OracleDbType.Varchar2, 45, nombre, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("CEDULA", OracleDbType.Varchar2, 45, cedula, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("CONTRASENA", OracleDbType.Varchar2, 45, contrasena, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("CORREO", OracleDbType.Varchar2, 200, correo, ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public UsuarioUser buscarUsuario(string cedula)
        {
            UsuarioUser usuario = null;
            try
            {
                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.BUSCAR_USUARIO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("CEDULA", OracleDbType.Varchar2, cedula, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idusuario=Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string rol = oracle.getSetLeer.GetValue(1).ToString();
                    string categoria = oracle.getSetLeer.GetValue(2).ToString();
                    string nombre=oracle.getSetLeer.GetValue(3).ToString();
                    cedula=oracle.getSetLeer.GetValue(4).ToString();
                    string correo=oracle.getSetLeer.GetValue(5).ToString();
                    string activo=oracle.getSetLeer.GetValue(6).ToString();
                    int incumplimiento = Convert.ToInt32(oracle.getSetLeer.GetValue(7));
                    usuario= new UsuarioUser(idusuario,rol,categoria,nombre,cedula,correo,activo,incumplimiento);
                    return usuario;
                }
                return usuario;
            }
            catch
            {
                return usuario;
            }
        }

        public int eliminarUsuario(string cedula)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("GESTION_USUARIOS.ELIMINAR_USUARIO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("CEDULA", OracleDbType.Varchar2,cedula, ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;

            }
            catch
            {
                return -1;
            }
        }
        

        //PAQUETE DE MULTAS
        public List<Multa> mostrarMultas()
        {
            List<Multa> multas = new List<Multa>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_PAGOS.MOSTRAR_MULTAS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                //oracle.getSetComando.ExecuteNonQuery();
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idmulta = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idcita = Convert.ToInt32(oracle.getSetLeer.GetValue(1));
                    string descripcion = oracle.getSetLeer.GetValue(2).ToString();
                    string fecha = oracle.getSetLeer.GetValue(3).ToString();
                    int valor = Convert.ToInt32(oracle.getSetLeer.GetValue(4));
                    Multa multa = new Multa(idmulta, idcita, descripcion, fecha, valor);
                    multas.Add(multa);
                }
                return multas;

            }
            catch
            {
                return multas;
            }
        }

        public  int registrarMulta(int idcita, string descripcion, string fecha, int valor)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_PAGOS.REGISTRAR_MULTA", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VIDCITA", OracleDbType.Int32, idcita, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VDESCRIPCION", OracleDbType.Varchar2, descripcion, ParameterDirection.Input);
                //oracle.getSetComando.Parameters.Add("VFECHA", OracleDbType.Date, DateTime.Parse(fecha), ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VFECHA", OracleDbType.Date, Convert.ToDateTime(fecha).ToString("dd-MMM-yyyy"), ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VVALOR", OracleDbType.Int32, valor, ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public List<PagoMulta> mostrarPagoMultas()
        {
            List<PagoMulta> pagomultas = new List<PagoMulta>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_PAGOS.MOSTRAR_PAGOMULTAS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idpagomulta = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idmulta = Convert.ToInt32(oracle.getSetLeer.GetValue(1));
                    string fecha = oracle.getSetLeer.GetValue(2).ToString();
                    PagoMulta pagomulta = new PagoMulta(idpagomulta,idmulta,fecha);
                    pagomultas.Add(pagomulta);
                }
                return pagomultas;

            }
            catch
            {
                return pagomultas;
            }
        }

        public int registrarPagoMulta(int idmulta, string fecha)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_PAGOS.PAGAR_MULTA", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VIDMULTA", OracleDbType.Int32, idmulta, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VFECHA", OracleDbType.Date, Convert.ToDateTime(fecha).ToString("dd-MMM-yyyy"), ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }


        public List<Copago> mostrarCopagos()
        {
            List<Copago> copagos = new List<Copago>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_PAGOS.MOSTRAR_COPAGOS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                //oracle.getSetComando.ExecuteNonQuery();
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idcopago = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idcita = Convert.ToInt32(oracle.getSetLeer.GetValue(1));
                    string fecha = oracle.getSetLeer.GetValue(2).ToString();
                    int valor = Convert.ToInt32(oracle.getSetLeer.GetValue(3));
                    Copago pagomulta = new Copago(idcopago, idcita, fecha,valor);
                    copagos.Add(pagomulta);
                }
                return copagos;

            }
            catch
            {
                return copagos;
            }
        }

        public List<PagoCopago> mostrarPagoCopagos()
        {
            List<PagoCopago> pagocopagos = new List<PagoCopago>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_PAGOS.MOSTRAR_PAGOCOPAGOS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idpagocopago = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idcopago = Convert.ToInt32(oracle.getSetLeer.GetValue(1));
                    string fecha = oracle.getSetLeer.GetValue(2).ToString();
                    PagoCopago pagocopago = new PagoCopago(idpagocopago, idcopago, fecha);
                    pagocopagos.Add(pagocopago);
                }
                return pagocopagos;

            }
            catch
            {
                return pagocopagos;
            }
        }

        public int registrarPagoCopago(int idcopago, string fecha)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_PAGOS.PAGAR_COPAGO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VIDMULTA", OracleDbType.Int32, idcopago, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VFECHA", OracleDbType.Date, Convert.ToDateTime(fecha).ToString("dd-MMM-yyyy"), ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public bool desconectar()
        {
            try
            {
                oracle.getSetConeccion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    
    
        //ADMINISTRACION DE CITAS
        public int obtenerIdmedico(int idusuario)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_CITAS.OBTENER_IDMEDICO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idusuario, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PIDMEDICO", OracleDbType.Int32, ParameterDirection.Output);
                oracle.getSetComando.ExecuteNonQuery();

                int idmedico=Convert.ToInt32(oracle.getSetComando.Parameters["PIDMEDICO"].Value.ToString());
                
                return idmedico;
            }
            catch
            {
                return -2;
            }
        }

        public List<Agenda> mostrarAgenda()
        {
            List<Agenda> agendas = new List<Agenda>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CITAS.MOSTRAR_AGENDA", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDMEDICO", OracleDbType.Int32,this.idmedico, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idagente = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string fecha = oracle.getSetLeer.GetValue(1).ToString();
                    int hora= Convert.ToInt32(oracle.getSetLeer.GetValue(2).ToString());
                    string disponible = oracle.getSetLeer.GetValue(3).ToString();
                    Agenda agenda = new Agenda(idagente,this.idmedico,fecha,hora,disponible);
                    agendas.Add(agenda);
                }
                return agendas;

            }
            catch
            {
                return agendas;
            }
        }
    
        public int registrarAgenda(string fecha, int hora)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_PAGOS.PAGAR_COPAGO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDMEDICO", OracleDbType.Int32, this.idmedico, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PFECHA", OracleDbType.Date, Convert.ToDateTime(fecha).ToString("dd-MMM-yyyy"), ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PHORA", OracleDbType.Int32, hora, ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
    
        public List<CitaUser> mostrarCitasMedico()
        {
            List<CitaUser> citas = new List<CitaUser>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CITAS.MOSTRAR_CITAS_MEDICO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDMEDICO", OracleDbType.Int32, this.idmedico, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idcita = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string tipoatencion = oracle.getSetLeer.GetValue(1).ToString();
                    string nombreusuario = oracle.getSetLeer.GetValue(2).ToString();
                    string fecha = oracle.getSetLeer.GetValue(3).ToString();
                    int hora = Convert.ToInt32(oracle.getSetLeer.GetValue(4).ToString());
                    CitaUser cita = new CitaUser(idcita,tipoatencion, nombreusuario, fecha, hora);
                    citas.Add(cita);
                }
                return citas;

            }
            catch
            {
                return citas;
            }
        }
    
        //PAQUETE ADMINISTRACION DE CURSOS Y NOTICIAS

        public List<Curso>mostrarCursos()
        {
            List<Curso> cursos= new List<Curso>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CURSOS.MOSTRAR_CURSOS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idcurso = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string titulo = oracle.getSetLeer.GetValue(1).ToString();
                    string descripcion = oracle.getSetLeer.GetValue(2).ToString();
                    int duracion = Convert.ToInt32(oracle.getSetLeer.GetValue(3));
                    string fechainicio = oracle.getSetLeer.GetValue(4).ToString();
                    string fechafin = oracle.getSetLeer.GetValue(5).ToString();
                    Curso curso = new Curso(idcurso, titulo, descripcion,duracion, fechainicio, fechafin);
                    cursos.Add(curso);
                }
                return cursos;

            }
            catch
            {
                return cursos;
            }
        }
    
        public List<Noticia> mostrarNoticias()
        {
            List<Noticia> noticias= new List<Noticia>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CURSOS.MOSTRAR_NOTICIAS", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idnoticia = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string titulo = oracle.getSetLeer.GetValue(1).ToString();
                    string descripcion = oracle.getSetLeer.GetValue(2).ToString();
                    string fecha = oracle.getSetLeer.GetValue(3).ToString();
                    string ubicacion = oracle.getSetLeer.GetValue(4).ToString();
                    Noticia noticia= new Noticia(idnoticia, titulo,descripcion,fecha,ubicacion);
                    noticias.Add(noticia);
                }
                return noticias;

            }
            catch
            {
                return noticias;
            }
        }
        
        public int registrarCurso(int idcurso, int idusuario)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_CURSOS.REGISTRAR_CURSO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDCURSO", OracleDbType.Int32, idcurso, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idusuario, ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public List<Programacion> MostrarProgramacion(int idusuario)
        {
            List<Programacion> programaciones = new List<Programacion>();
            //try
            //{

                oracle.getSetComando = new OracleCommand("ADM_CURSOS.MOSTRAR_PROGRAMACION", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idusuario, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idprogramacion = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idcurso = Convert.ToInt32(oracle.getSetLeer.GetValue(1).ToString());
                    string actividad = oracle.getSetLeer.GetValue(2).ToString();
                    string ubicacion = oracle.getSetLeer.GetValue(3).ToString();
                    Programacion programacion= new Programacion(idprogramacion,idcurso,actividad,ubicacion);
                    programaciones.Add(programacion);
                }
                return programaciones;

            //}
            //catch
            //{
            //    return programaciones;
            //}
        }

        //PAQUETE DE CITAS
        public List<CitaUser> mostrarCitasAfiliado(int idusuario)
        {
            List<CitaUser> citas = new List<CitaUser>();
            //try
            //{

                oracle.getSetComando = new OracleCommand("ADM_CITAS.MOSTRAR_CITAS_AFILIADO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idusuario, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idcita = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string tipoatencion = oracle.getSetLeer.GetValue(1).ToString();
                    string fecha = oracle.getSetLeer.GetValue(2).ToString();
                    int hora = Convert.ToInt32(oracle.getSetLeer.GetValue(3).ToString());
                    CitaUser cita = new CitaUser(idcita, tipoatencion, null, fecha, hora);
                    citas.Add(cita);
                }
                return citas;

            //}
            //catch
            //{
            //    return citas;
            //}
        }

        public List<Atencion> mostrarAtencion()
        {
            List<Atencion> atenciones= new List<Atencion>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CITAS.MOSTRAR_ATENCION", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idatencion = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    string tipoatencion = oracle.getSetLeer.GetValue(1).ToString();
                    Atencion atencion= new Atencion(idatencion, tipoatencion);
                    atenciones.Add(atencion);
                }
                return atenciones;

            }
            catch
            {
                return atenciones;
            }
        }

        public List<Agenda> mostrarAgendaAfiliado()
        {
            List<Agenda> agendas = new List<Agenda>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CITAS.MOSTRAR_AGENDA_DISPONIBLE", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idagenda = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idmedico = Convert.ToInt32(oracle.getSetLeer.GetValue(1));
                    string medico = oracle.getSetLeer.GetValue(2).ToString();
                    string fecha = oracle.getSetLeer.GetValue(3).ToString();
                    int hora = Convert.ToInt32(oracle.getSetLeer.GetValue(4).ToString());
                    string especialidad=oracle.getSetLeer.GetValue(5).ToString();
                    Agenda agenda = new Agenda(idagenda,idmedico,medico,fecha,hora,especialidad,null);
                    agendas.Add(agenda);
                }
                return agendas;

            }
            catch
            {
                return agendas;
            }
        }

        public int registrarCita(int idatencion,int idusuario,int idagenda)
        {
            try
            {
                oracle.getSetComando = new OracleCommand("ADM_CURSOS.REGISTRAR_CITA", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDATENCION", OracleDbType.Int32, idatencion, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PIDMEDICO", OracleDbType.Int32, 1, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idusuario, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idagenda, ParameterDirection.Input);
                oracle.getSetComando.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public List<Copago> mostrarCopagosAfiliado(int idusuario)
        {
            List<Copago> copagos = new List<Copago>();
            try
            {

                oracle.getSetComando = new OracleCommand("ADM_CITAS.MOSTRAR_COPAGOS_AFILIADO", oracle.getSetConeccion);
                oracle.getSetComando.CommandType = CommandType.StoredProcedure;
                oracle.getSetComando.Parameters.Add("PIDUSUARIO", OracleDbType.Int32, idusuario, ParameterDirection.Input);
                oracle.getSetComando.Parameters.Add("VARIABLE_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                oracle.getSetLeer = oracle.getSetComando.ExecuteReader();

                while (oracle.getSetLeer.Read())
                {
                    int idcopago = Convert.ToInt32(oracle.getSetLeer.GetValue(0));
                    int idcita = Convert.ToInt32(oracle.getSetLeer.GetValue(1));
                    string fecha = oracle.getSetLeer.GetValue(2).ToString();
                    int valor = Convert.ToInt32(oracle.getSetLeer.GetValue(3).ToString());
                    Copago agenda = new Copago(idcopago,idcita,fecha,valor);
                    copagos.Add(agenda);
                }
                return copagos;

            }
            catch
            {
                return copagos;
            }
        }
    }
}