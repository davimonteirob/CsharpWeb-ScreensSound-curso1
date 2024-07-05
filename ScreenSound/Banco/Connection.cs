using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ScreenSound.Banco
{
    internal class Connection
    {
        //Classe responsável por fazer a conecção com o nosso banco de dados

        //para fazer a conecção, precisamos passar o caminho, para que se possa identificar onde está o nosso banco de dados.
        private string connectionString = "Data Source=DESKTOP-KM1NEG8;Initial Catalog=ScreenSound;User ID=sa;Password=********;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //tiramos o 'connection timeout = 30' a fim de ser mais rapido e não limitar durante a aula

        //precisamos de um método para utilizar a string de conexão e conectar com o banco de dados
        public SqlConnection ObterConexao()
        {
            //assim fazemos a conexão com o banco de dados através deste método ObterConexao();
            return new SqlConnection(connectionString);
        }

        
    }



}
