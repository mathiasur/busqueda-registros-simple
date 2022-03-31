using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  IMPORTAMOS LIBRERIA SQL
using System.Data.SqlClient;

namespace busqueda_registros.DataAccessObject
{
    internal class ConexionDB
    {
        protected SqlConnection Conexion = new SqlConnection(@"Data Source=MATHIAS-PC\SQLEXPRESS;Initial Catalog=Practica_Patrones;Persist Security Info=True;User ID=sa;Password=admin1234");
    }
}
