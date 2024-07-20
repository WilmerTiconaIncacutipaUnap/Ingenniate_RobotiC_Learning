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
    public class RepositorioMasivo : IRepositorioMasivo
    {
        private string CadenaConexion;
        private readonly ILogger<RepositorioMasivo> log;
        public RepositorioMasivo(AccesoDatos cadenaConexion, ILogger<RepositorioMasivo> l)
        {
            CadenaConexion = cadenaConexion.CadenaConexionSQL;
            log = l;
        }
        private SqlConnection conexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        public async Task<IEnumerable<Curso>> PrimerVolcadoDatos()
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
                Comm.CommandText = "dbo.CargaIncialDatos";
                Comm.CommandType = CommandType.StoredProcedure;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    curso = new Curso();
                    curso.Id = Convert.ToInt32(reader["id"]);
                    curso.NombreCurso = reader["Nombre"].ToString();
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
                listaCursos[0].error.mensaje = "Se produjo un error en el primer volcado en nuestra BBDD : " + ex.Message;
                listaCursos[0].error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error en el primer volcado en nuestra BBDD :" + ex.ToString());
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
                listaCursos[0].error.mensaje = "Se produjo un error en el primer volcado: " + ex.ToString();
                listaCursos[0].error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error en el primer volcado en nuestra BBDD :" + ex.ToString());
            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return listaCursos;
        }

        public async Task<IEnumerable<Curso>> DameCursos()
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
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    curso = new Curso();
                    curso.Id = Convert.ToInt32(reader["idCurso"]);
                    curso.NombreCurso = reader["Nombre"].ToString();
                    curso.Descripcion = reader["Descripcion"].ToString();
                    curso.RutaImagen = reader["RutaImagen"].ToString();
                    curso.Programa = reader["Programa"].ToString();
                    curso.RutaImagen= reader["RutaImagen"].ToString();

                    if (reader["Programa"]!=null)
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
                listaCursos[0].error.mensaje = "Se produjo un error al obtener los cursos del usuario en nuestra BBDD   : " + ex.Message;
                listaCursos[0].error.mostrarEnPantalla = true;
                log.LogError("Se produjo un error al obtener los cursos del usuario en nuestra BBDD   :" + ex.ToString());
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
                listaCursos[0].error.mensaje = "Se produjo un error al obtener los cursos del usuario:: " + ex.ToString();
                listaCursos[0].error.mostrarEnPantalla = false;
                log.LogError("Se produjo un error al obtener los cursos del usuario: :" + ex.ToString());

            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return listaCursos;
        }
    }
}
