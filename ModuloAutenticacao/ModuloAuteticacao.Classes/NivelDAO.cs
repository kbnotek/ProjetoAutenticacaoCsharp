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
        public string Atualizar()
        {
            return "Você vai Atualiar";
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
        public string Deletar()
        {
            return "Voce vai Deletar";
        }
        public string CarregarGrid()
        {
            return "Carregamdo Formulario";
        }
    }
}
