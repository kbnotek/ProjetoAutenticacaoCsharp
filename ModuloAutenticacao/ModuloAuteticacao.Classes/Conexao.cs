//Namespace = Pasta ( Lógica )
using System.Data.SqlClient;
//Classe do Módulo 
namespace ModuloAuteticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;
        public static SqlConnection MinhaInstancia
        { //a chave da propriedade
            get
            { // chave do método get
              //se não existe conexão.
                if (_conn == null)
                { // chave do if
                    //Criar a conexão com SqlServer // Nos Parentes - Connection String com os dados do SQLSERVER 
                    _conn = new SqlConnection(@"Server = Lab206_1\MSSQLSERVER1; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                } // fecha chave do if
                  //retorna a conexão
                return _conn;
            }
        }
    }
}



    