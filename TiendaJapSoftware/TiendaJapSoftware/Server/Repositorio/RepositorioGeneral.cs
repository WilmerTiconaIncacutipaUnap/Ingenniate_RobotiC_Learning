using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TiendaJapSoftware.Server.Datos;
using TiendaJapSoftware.Shared;

namespace TiendaJapSoftware.Server.Repositorio
{
    public class RepositorioGeneral : IRepositorioGeneral
    {
        private string CadenaConexion;
        private readonly ILogger<RepositorioGeneral> log;

        public RepositorioGeneral(AccesoDatos cadenaConexion, ILogger<RepositorioGeneral> l)
        {
            CadenaConexion = cadenaConexion.CadenaConexionSQL;
            this.log = l;

        }
        private SqlConnection conexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        public async Task<Usuario> GuardarCursos(Usuario u)
        {
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlTransaction transaccion=null;

            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                transaccion = sqlConexion.BeginTransaction();
                Comm.CommandText = "dbo.CursosUsuarioInscribir";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Transaction = transaccion;
                foreach (Curso c in u.ListaCursos)
                {
                    Comm.Parameters.Clear();
                    Comm.Parameters.Add("@idCurso", SqlDbType.Int).Value = c.Id;
                    Comm.Parameters.Add("@emailUsuario", SqlDbType.VarChar, 500).Value = u.Email;
                    await Comm.ExecuteNonQueryAsync();
                    
                }
                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                if (transaccion != null)
                    transaccion.Rollback();

                u.error = new Error();
                u.error.mensaje = "Se produjo un error al guardar los cursos en nuestra BBDD : " + ex.Message;
                u.error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al guardar los cursos en nuestra BBDD :" + ex.ToString());
            }

            catch (Exception ex)
            {
                if(transaccion!=null)
                    transaccion.Rollback();
                
                u.error = new Error();
                u.error.mensaje = "Se produjo un error al guardar los cursos: " + ex.ToString();
                u.error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al guardar los cursos: " + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return u;
        }

        public async Task<Usuario> AltaUsuario(Usuario u)
        {
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.AltaUsuario";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@nombre", SqlDbType.VarChar, 500).Value = u.Nombre;
                Comm.Parameters.Add("@apellidos", SqlDbType.VarChar, 500).Value = u.Apellido;
                Comm.Parameters.Add("@email", SqlDbType.VarChar, 500).Value = u.Email;
                Comm.Parameters.Add("@password", SqlDbType.VarChar, 500).Value = u.Password;

                await Comm.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                u.error = new Error();
                u.error.mensaje = "Se produjo un error al dar de alta nuestro usuario en nuestra BBDD : "+  ex.Message;
                u.error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al dar de alta nuestro usuario en nuestra BBDD :" + ex.ToString());
            }
            catch (Exception ex)
            {
                u.error = new Error();
                u.error.mensaje = "Se produjo un error al dar de alta nuestro usuario: " + ex.ToString();
                u.error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al dar de alta nuestro usuario: " + ex.ToString());
            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return u;
        }

        public async Task<UsuarioLogIn> ValidarUsuario(String email)
        {
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            UsuarioLogIn logIn = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.DameUsuario";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@email", SqlDbType.VarChar, 500).Value = email;

                SqlDataReader reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                {
                    logIn = new UsuarioLogIn();
                    logIn.Id = Convert.ToInt32(reader["id"].ToString());
                    logIn.EmailLogin = reader["Email"].ToString();
                    logIn.Password = reader["Password"].ToString();
                }
            }
            catch (SqlException ex)
            {
                if (logIn == null)
                    logIn = new UsuarioLogIn();
                logIn.error = new Error();
                logIn.error.mensaje = "Se produjo un error al obtener los datos del usuario en nuestra BBDD : " + ex.Message;
                logIn.error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al obtener los datos del usuario :" + ex.ToString());

            }            
            catch (Exception ex)
            {
                if (logIn == null)
                    logIn = new UsuarioLogIn();

                logIn.error = new Error();
                logIn.error.mensaje = "Se produjo un error al obtener los datos del usuario: " + ex.ToString();
                logIn.error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al obtener los datos del usuario:" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return logIn;
            
        }

        public async Task<Usuario> DameUsuario(String email)
        {
            Usuario u = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.DameUsuario";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@email", SqlDbType.VarChar, 500).Value = email;
                SqlDataReader reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                {
                    u = new Usuario();
                    u.Id = Convert.ToInt32(reader["id"]);
                    u.Email = reader["Email"].ToString();
                    u.Password = reader["Password"].ToString();
                    u.Nombre = reader["Nombre"].ToString();
                    u.Apellido = reader["Apellidos"].ToString();
                }
            }
            catch (SqlException ex)
            {
                if (u == null)
                    u = new Usuario();
                u.error = new Error();
                u.error.mensaje = "Se produjo un error al obtener usuario en nuestra BBDD : " + ex.Message;
                u.error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al obtener usuario en nuestra BBDD :" + ex.ToString());
             }
            catch (Exception ex)
            {
                if (u == null)
                    u = new Usuario();

                u.error = new Error();
                u.error.mensaje = "Se produjo un error al obtener los datos del usuario: " + ex.ToString();
                u.error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al obtener los datos del usuario :" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return u;
        }

        public async Task<IEnumerable<Curso>> DameCursos(string email)
        {
            List<Curso> listaCursos = new List<Curso>();
            Curso curso = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;

            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.DameCursos";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@Email", SqlDbType.VarChar, 500).Value = email;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {

                    curso = new Curso();
                    curso.Id = Convert.ToInt32(reader["idCurso"]);
                    curso.NombreCurso = reader["Nombre"].ToString();
                    curso.Descripcion = reader["Descripcion"].ToString();
                    curso.RutaImagen = reader["RutaImagen"].ToString();
                    if (reader["Programa"] != null)
                        curso.Programa = reader["Programa"].ToString();

                    if (reader["PrecioVenta"] != null && Convert.ToDouble(reader["PrecioVenta"]) > 0)
                    {
                        curso.Precio = new Precio();
                        curso.Precio.PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                        curso.Precio.Id = Convert.ToInt32(reader["IdPrecio"]);
                    }
                    listaCursos.Add(curso);

                }

            }
            catch (SqlException ex)
            {
                if (listaCursos[0] != null)
                    listaCursos[0].error = new Error();
                else
                {
                    listaCursos[0] = new Curso();
                    listaCursos[0].error = new Error();
                }
                listaCursos[0].error.mensaje = "Se produjo un error al obtener los cursos del usuario en nuestra BBDD : " + ex.Message;
                listaCursos[0].error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al obtener cursos en nuestra BBDD :" + ex.ToString());
             }
            catch (Exception ex)
            {
                if (listaCursos[0] != null)
                    listaCursos[0].error = new Error();
                else
                {
                    listaCursos[0] = new Curso();
                    listaCursos[0].error = new Error();
                }
                listaCursos[0].error.mensaje = "Se produjo un error al obtener los cursos del usuario: " + ex.ToString();
                listaCursos[0].error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al obtener los cursos del usuario :" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return listaCursos;
        }

        public async Task<IEnumerable<Curso>> DameCursos(int idUsuario)
        {
            List<Curso> listaCursos = new List<Curso>();
            Curso curso = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.DameCursosUsuario";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {

                    curso = new Curso();
                    curso.Id = Convert.ToInt32(reader["idCurso"]);
                    curso.NombreCurso = reader["Nombre"].ToString();
                    curso.Descripcion = reader["Descripcion"].ToString();
                    curso.RutaImagen = reader["RutaImagen"].ToString();
                    if (reader["Programa"] != null)
                        curso.Programa = reader["Programa"].ToString();

                    if (reader["PrecioVenta"] != null && Convert.ToDouble(reader["PrecioVenta"]) > 0)
                    {
                        curso.Precio = new Precio();
                        curso.Precio.PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                        curso.Precio.Id = Convert.ToInt32(reader["IdPrecio"]);
                    }
                    listaCursos.Add(curso);

                }

            }
            catch (SqlException ex)
            {
                if (listaCursos[0] != null)
                    listaCursos[0].error = new Error();
                else
                {
                    listaCursos[0] = new Curso();
                    listaCursos[0].error = new Error();
                }
                listaCursos[0].error.mensaje = "Se produjo un error al obtener los cursos del usuario en nuestra BBDD  : " + ex.Message;
                listaCursos[0].error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al obtener los cursos del usuario en nuestra BBDD  :" + ex.ToString());
            }
            catch (Exception ex)
            {
                if (listaCursos[0] != null)
                    listaCursos[0].error = new Error();
                else
                {
                    listaCursos[0] = new Curso();
                    listaCursos[0].error = new Error();
                }
                listaCursos[0].error.mensaje = "Se produjo un error al obtener los cursos del usuario: " + ex.ToString();
                listaCursos[0].error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al obtener los cursos del usuario  :" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return listaCursos;
        }

        public async Task<UsuarioLogIn> CambiarPass(UsuarioLogIn usuarioLogIn)
        {
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            UsuarioLogIn logIn = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CambiarPass";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@email", SqlDbType.VarChar, 500).Value = usuarioLogIn.EmailLogin;
                Comm.Parameters.Add("@pass", SqlDbType.VarChar, 500).Value = usuarioLogIn.Password;

                 await Comm.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                if (logIn == null)
                    logIn = new UsuarioLogIn();
                logIn.error = new Error();
                logIn.error.mensaje = "Se produjo un error al cambiar la password del usuario en nuestra BBDD : " + ex.Message;
                logIn.error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al cambiar la password del usuario :" + ex.ToString());

            }
            catch (Exception ex)
            {
                if (logIn == null)
                    logIn = new UsuarioLogIn();

                logIn.error = new Error();
                logIn.error.mensaje = "Se produjo un error al cambiar la password del usuario: " + ex.ToString();
                logIn.error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al cambiar la password del usuario:" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return logIn;

        }

        public async Task<UsuarioLogIn> ConfirmarAlta(String  email)
        {
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            UsuarioLogIn logIn = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.ActivarUsuario";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@email", SqlDbType.VarChar, 500).Value = email;
  
                await Comm.ExecuteNonQueryAsync();
                
            }
            catch (SqlException ex)
            {
                if (logIn == null)
                    logIn = new UsuarioLogIn();
                logIn.error = new Error();
                logIn.error.mensaje = "Se produjo un error al activar el usuario en nuestra BBDD : " + ex.Message;
                logIn.error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al activar el usuario:" + ex.ToString());

            }
            catch (Exception ex)
            {
                if (logIn == null)
                    logIn = new UsuarioLogIn();

                logIn.error = new Error();
                logIn.error.mensaje = "Se produjo un error al activar el usuario: " + ex.ToString();
                logIn.error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al activar el usuario:" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return logIn;
        }
    }

}
