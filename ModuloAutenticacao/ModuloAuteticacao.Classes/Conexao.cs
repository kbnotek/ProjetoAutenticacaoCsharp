using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAuteticacao.Classes
{
    internal class Conexao
    {

        public static DbConnection _conn;

        public static SqlConnection  MinhaInstacia { get; set; }


    }
}
