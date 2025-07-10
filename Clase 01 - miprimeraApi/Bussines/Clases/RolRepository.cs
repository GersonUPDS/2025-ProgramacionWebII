using miprimeraApi.Bussines.Contracts;
using miprimeraApi.Models;
using System.Data;
using System.Data.SqlClient;

namespace miprimeraApi.Bussines.Clases
{
    public class RolRepository : IRolRepository 
    {
        private readonly string connect;
        public RolRepository(IConfiguration configuration)
        {
            connect = configuration.GetConnectionString("conBase");
        }

        public async Task<List<Rol>> GetList()
        {
            List<Rol> list = new List<Rol>();
            Rol l;
            using(SqlConnection conn = new SqlConnection(connect)) 
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rol;",conn);
                using(var reader = cmd.ExecuteReader()) {
                    while (await reader.ReadAsync()) 
                    {
                        l = new Rol();
                        l.ID = Convert.ToInt32(reader["id"]);
                        l.NombreRol = Convert.ToString(reader["NombreRol"]);

                        list.Add(l);
                    }
                }

            }

            return list;
        }

        
    }
    
}
