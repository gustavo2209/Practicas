using Practicas.Examen_Final.Dominio.Entities;
using Practicas.Examen_Final.Dominio.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Examen_Final.Infraestructura
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
            var sql = "SELECT customerId, CONCAT(FirstName, ' ', LastName) AS FullName FROM Customer ORDER BY 1";

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

        public List<TrackLista> mostrarTracks()
        {
            var resultadoTracks = new List<TrackLista>();
            var sql = "SELECT TrackId, Name FROM Track ORDER BY 1";

            using (var cnx = this.CreateDbConnection())
            {
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                cnx.Open();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultadoTracks.Add(InvoiceQueryTracksMapping(reader));
                }
            }
            return resultadoTracks;
        }

        private TrackLista InvoiceQueryTracksMapping(IDataReader reader)
        {
            var entidad = new TrackLista();

            var indice = 0;

            indice = reader.GetOrdinal("name");
            entidad.Name = reader.GetString(indice);

            return entidad;
        }

        public int Insertar(Invoice entity)
        {
            int result = 0;
            using (var cnx = this.CreateDbConnection())
            {
                cnx.Open();

                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "usp_InsertInvoice";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParameter("@CustomerId", entity.CustomerId));
                cmd.Parameters.Add(CreateParameter("@InvoiceDate", entity.InvoiceDate));
                cmd.Parameters.Add(CreateParameter("@BillingAddress", entity.BillingAddress));
                cmd.Parameters.Add(CreateParameter("@BillingCity", entity.BillingCity));
                cmd.Parameters.Add(CreateParameter("@BillingState", entity.BillingState));
                cmd.Parameters.Add(CreateParameter("@BillingCountry", entity.BillingCountry));
                cmd.Parameters.Add(CreateParameter("@BillingPostalCode", entity.BillingPostalCode));
                cmd.Parameters.Add(CreateParameter("@Total", entity.Total));

                result = Convert.ToInt32(cmd.ExecuteScalar());

                foreach(var item in entity.InvoiceLine)
                {
                    IDbCommand cmdDetalle = cnx.CreateCommand();
                    cmdDetalle.CommandText = "ups_InsertInvoiceLine";
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.Add(CreateParameter("@InvoiceId", result));
                    cmdDetalle.Parameters.Add(CreateParameter("@TrackId", item.TrackId));
                    cmdDetalle.Parameters.Add(CreateParameter("@UnitPrice", item.UnitPrice));
                    cmdDetalle.Parameters.Add(CreateParameter("@Quantity", item.Quantity));

                    cmdDetalle.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}
