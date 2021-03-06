using Practicas.Cap24.Dominio.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap24.Infraestructura
{
    public class InvoiceRepositorio : BaseRepositorio
    {
        public List<InvoiceQuery> ConsultarFacturas(DateTime date1, DateTime date2)
        {
            var resultado = new List<InvoiceQuery>();
            var sql = "sp_ObtenerFacturas";

            using (var cnx = this.CreateDbConnection())
            {
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;

                //AGREGANDO LOS PARAMETROS

                cmd.Parameters.Add(this.CreateParameter("@Tipo", 1));
                cmd.Parameters.Add(this.CreateParameter("@date1", date1));
                cmd.Parameters.Add(this.CreateParameter("@date2", date2));

                cnx.Open(); // ABRIENDO LA CONEXION A LA BASE DE DATOS

                var reader = cmd.ExecuteReader(); // EJECUTANDO LA CONSULTA SQL (EN ESTE CASO EL PROCEDIMIENTO ALMACENADO)

                while (reader.Read())
                {
                    resultado.Add(InvoiceQueryMapping(reader));
                }
            }

            return resultado;

        }

        public List<InvoiceQuery> ConsultarFacturasTodo()
        {
            var resultado = new List<InvoiceQuery>();
            var sql = "sp_ObtenerFacturas";

            using (var cnx = this.CreateDbConnection())
            {
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;

                //AGREGANDO LOS PARAMETROS

                cmd.Parameters.Add(this.CreateParameter("@Tipo", 3));
                cmd.Parameters.Add(this.CreateParameter("@date1", ""));
                cmd.Parameters.Add(this.CreateParameter("@date2", ""));

                cnx.Open(); // ABRIENDO LA CONEXION A LA BASE DE DATOS

                var reader = cmd.ExecuteReader(); // EJECUTANDO LA CONSULTA SQL (EN ESTE CASO EL PROCEDIMIENTO ALMACENADO)

                while (reader.Read())
                {
                    resultado.Add(InvoiceQueryMapping(reader));
                }
            }

            return resultado;

        }

        public int ConsultarFacturasCantidad(DateTime date1, DateTime date2)
        {
            var sql = "sp_ObtenerFacturas";
            int cantidad = 0;

            using (var cnx = this.CreateDbConnection())
            {
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;

                //AGREGANDO LOS PARAMETROS

                cmd.Parameters.Add(this.CreateParameter("@Tipo", 2));
                cmd.Parameters.Add(this.CreateParameter("@date1", date1));
                cmd.Parameters.Add(this.CreateParameter("@date2", date2));

                cnx.Open(); // ABRIENDO LA CONEXION A LA BASE DE DATOS

                cantidad = Convert.ToInt32(cmd.ExecuteScalar());

            }

            return cantidad;

        }

        public int ConsultarFacturasCantidadTotal()
        {
            var sql = "sp_ObtenerFacturas";
            int cantidad = 0;

            using (var cnx = this.CreateDbConnection())
            {
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;

                //AGREGANDO LOS PARAMETROS

                cmd.Parameters.Add(this.CreateParameter("@Tipo", 4));
                cmd.Parameters.Add(this.CreateParameter("@date1", ""));
                cmd.Parameters.Add(this.CreateParameter("@date2", ""));

                cnx.Open(); // ABRIENDO LA CONEXION A LA BASE DE DATOS

                cantidad = Convert.ToInt32(cmd.ExecuteScalar());

            }

            return cantidad;

        }

        private InvoiceQuery InvoiceQueryMapping(IDataReader reader)
        {
            var entidad = new InvoiceQuery();

            var indice = 0;
            indice = reader.GetOrdinal("InvoiceId");
            entidad.InvoiceId = reader.GetInt32(indice);

            indice = reader.GetOrdinal("CustomerId");
            entidad.CustomerId = reader.GetInt32(indice);

            indice = reader.GetOrdinal("FirstName");
            entidad.FirstName = reader.GetString(indice);

            indice = reader.GetOrdinal("LastName");
            entidad.LastName = reader.GetString(indice);

            indice = reader.GetOrdinal("Total");
            entidad.Total = reader.GetDecimal(indice);

            return entidad;
        }

        public List<ClientesLista> mostrarClientes()
        {
            var resultadoClientes = new List<ClientesLista>();
            var sql = "SELECT CONCAT(FirstName, ' ', LastName) AS FullName FROM Customer ORDER BY 1 DESC";

            using (var cnx = this.CreateDbConnection())
            {
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                cnx.Open();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultadoClientes.Add(InvoiceQueryClientesMapping(reader));
                }
            }
            return resultadoClientes;
        }

        private ClientesLista InvoiceQueryClientesMapping(IDataReader reader)
        {
            var entidad = new ClientesLista();

            var indice = 0;

            indice = reader.GetOrdinal("Fullname");
            entidad.FullName = reader.GetString(indice);

            return entidad;
        }
    }
}
