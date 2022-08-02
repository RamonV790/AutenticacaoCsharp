using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAuteticacao.Classes
{
    internal class Conexao
    {

        public static SqlConnection _conn;

        public SqlConnection MinhaInstancia
        { //a chave da propriedade
            get
            { // chave do método get
              //se não existe conexão.
                if (_conn == null)
                { // chave do if
                    _conn = new SqlConnection(@"Server = localhost; Database = projetoestoquev; Uid = sa; Pwd = teste*123;");
                } // fecha chave do if
                  //retorna a conexão
                return _conn;
            }
        }
    }
}
