using System.Data.SqlClient;
using System.Data;

namespace ModuloAuteticacao.Classes
{
    public class NivelDAO
    {
        public string Inserir(string nome)
        {  
            //Abrindo a Conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o Comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de Comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML 
            comando.CommandText = "INSERT INTO Nivel(nome)Values(@Nome)";
            //Adicionando Parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo Pronto ! Vamos Executar o comando.
            comando.ExecuteNonQuery();
            //Fechar a Conexão
            Conexao.MinhaInstancia.Close();
            
            return "Dados Inseridos com Sucesso!";

        }
        public string Atualizar(string Id, string Nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("update Nivel set Nome=@Nome where codigo=@ID;");
            comando.Parameters.AddWithValue("@ID", Id);
            comando.Parameters.AddWithValue("@Nome", Nome);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Atualizado com Sucesso!";
        
        }
        public DataTable Pesquisar() 
        {
            //Abrindo a Conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o Comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de Comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML 
             comando.CommandText = "SELECT * FROM Nivel";         
            //DataTable (BANCO DE DADOS NA MEMORIA )
            DataTable dataTable = new DataTable();
            //Metodo de Leitura - Execução de Leitura
            SqlDataReader reader = comando.ExecuteReader();
            //Carregar Leitura 
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
        public string Deletar(string Id)
        {

            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("DELETE Nivel WHERE codigo=@ID;");
            comando.Parameters.AddWithValue("@ID", Id);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();
            return "Deletado com Sucesso!";


        }
        public string CarregarGrid()
        {
            return "Carregando Formulario";
        }
        public DataTable Pesquisar(string nome) //Sobre carga de metódo com o mesmo nome ( @Overload )
        {
            //Abrindo a Conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o Comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de Comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML 
            comando.CommandText = "SELECT * FROM Nivel WHERE Nome =@Nome";
            //Adicionando Parâmetros contra SQL Injection
            comando.Parameters.AddWithValue("@Nome", nome);
            //DataTable (BANCO DE DADOS NA MEMORIA )
            DataTable dataTable = new DataTable();
            //Metodo de Leitura - Execução de Leitura
            SqlDataReader reader = comando.ExecuteReader();
            //Carregar Leitura 
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
        public DataTable Pesquisar2(string Id) //Sobre carga de metódo com o mesmo nome ( @Overload )
        {
            //Abrindo a Conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o Comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de Comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML 
            comando.CommandText = "SELECT * FROM Nivel WHERE Codigo =@Codigo";
            //Adicionando Parâmetros contra SQL Injection
            comando.Parameters.AddWithValue("@Codigo", Id);
            //DataTable (BANCO DE DADOS NA MEMORIA )
            DataTable dataTable = new DataTable();
            //Metodo de Leitura - Execução de Leitura
            SqlDataReader reader = comando.ExecuteReader();
            //Carregar Leitura 
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
    }
}
