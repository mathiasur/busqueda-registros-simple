using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// IMPORTAMOS LIBRERIAS SQL
using System.Data;
using System.Data.SqlClient;
using busqueda_registros.DataTransferObject;

namespace busqueda_registros.DataAccessObject
{
    internal class ClienteDAO : ConexionDB
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();

        // CRUD
        public List<ClientesDTO> VerRegistros(string condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", condicion);
            Conexion.Open();
            LeerFilas = Comando.ExecuteReader();
            List<ClientesDTO> ListaGenerica = new List<ClientesDTO>();
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClientesDTO
                {
                    ID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }

    }
}
