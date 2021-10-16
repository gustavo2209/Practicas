using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Examen_Final.Infraestructura
{
    public abstract class BaseRepositorio
    {
        public IDbConnection CreateDbConnection()
        {
            string connectionString = "Data source=DESKTOP-464M9J2; Initial Catalog=Chinook; Integrated Security=true;";

            return new SqlConnection(connectionString);
        }

        public IDataParameter CreateParameter(string parameterName, object parameterValue)
        {
            return new SqlParameter(parameterName, parameterValue);
        }
    }
}
