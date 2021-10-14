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

                //AGREGANDO LOS PARAMETROS

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

            return entidad;
        }
    }
}
