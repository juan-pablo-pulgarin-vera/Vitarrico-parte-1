using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vitarrico
{
    internal class ConexionSQLServer
    {
        string cadenaConexion = "Data Source=DESKTOP-L67TU5J\\SQLEXPRESS; Initial Catalog=Vitarrico; Integrated Security=True";
        public SqlConnection ConectarBD = new SqlConnection();

        public ConexionSQLServer()
        {
            ConectarBD.ConnectionString = cadenaConexion;
        }

        public void AbrirConexion()
        {
            try
            {
                ConectarBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar " + ex.ToString());
            }
        }
    }
}
