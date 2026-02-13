using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public static class BancoDeDados
    {
        const string connectionString = "Server=localhost;Database=uc12;Uid=root;";// Caminho + Autenticação do nosso banco de dados

        public static bool InserirJogador(Jogador jogador)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Criando uma instância de conexão
            {
                MySqlTransaction transaction = null;
                try
                {
                    connection.Open(); // Nesse momento eu estou batendo na porta do meu banco e abrindo uma conexão

                    transaction = connection.BeginTransaction();
                    // 1. INSERT Jogos
                    string sqlJogos = @"
                                          INSERT INTO Jogos
                                          (Nome, Plataforma, Tempo, Nota)
                                          VALUES
                                          (@Nome, @Plataforma, @Tempo, @Nota);
                                          SELECT LAST_INSERT_ID();";

                    int jogosId;

                    using (MySqlCommand cmdJogos = new MySqlCommand(sqlJogos, connection, transaction))
                    {
                        cmdJogos.Parameters.AddWithValue("@Nome", jogador.Jogos.Nome);
                        cmdJogos.Parameters.AddWithValue("@Plataforma", jogador.Jogos.Plataforma);
                        cmdJogos.Parameters.AddWithValue("@Tempo", jogador.Jogos.Tempo);
                        cmdJogos.Parameters.AddWithValue("@Nota", jogador.Jogos.Nota);

                        jogosId = Convert.ToInt32(cmdJogos.ExecuteScalar());
                    }

                    // 2. INSERT Jogador
                    string sqlJogador = @"INSERT INTO Jogador
                                        (Nome, Idade, Genero, Nacionalidade, JogosId)
                                        VALUES
                                        (@Nome, @Idade, @Genero, @Nacionalidade, @JogosId);";

                    using (MySqlCommand cmdJogador = new MySqlCommand(sqlJogador, connection, transaction))
                    {
                        cmdJogador.Parameters.AddWithValue("@Nome", jogador.Nome);
                        cmdJogador.Parameters.AddWithValue("@Idade", jogador.Idade);
                        cmdJogador.Parameters.AddWithValue("@Genero", jogador.Genero);
                        cmdJogador.Parameters.AddWithValue("@Nacionalidade", jogador.Nacionalidade);
                        cmdJogador.Parameters.AddWithValue("@JogosId", jogosId);

                        cmdJogador.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (transaction != null)
                        transaction.Rollback();
                    return false;
                }

            }
        }

        public static List<Jogador> BuscaJogador()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Criando uma instância de conexão
            {
                try
                {
                    List<Jogador> jogadores = new List<Jogador>();
                    connection.Open(); // Nesse momento eu estou batendo na porta do meu banco e abrindo uma conexão

                    // 1. INSERT Jogos
                    string sqlJogos = @"select m.*, a.* from jogador a inner join Jogos m on m.Id = a.JogosId;";

                    using (MySqlCommand cmdJogos = new MySqlCommand(sqlJogos, connection))
                    {
                        MySqlDataReader resultado = cmdJogos.ExecuteReader();

                        while (resultado.Read())
                        {
                            Jogador jogador = new Jogador();
                            jogador.Jogos.Id = Convert.ToInt32(resultado[0]);
                            jogador.Jogos.Nome = resultado[1].ToString();   
                            jogador.Jogos.Plataforma = resultado[2].ToString();
                            jogador.Jogos.Tempo = Convert.ToInt32(resultado[3]);
                            jogador.Jogos.Nota = Convert.ToInt32(resultado[4]);
                            jogador.Id = Convert.ToInt32(resultado[5]);
                            jogador.Nome = resultado[6].ToString();
                            jogador.Idade = Convert.ToInt32(resultado[7]);
                            jogador.Genero = resultado[8].ToString();
                            jogador.Nacionalidade = resultado[9].ToString();

                            jogadores.Add(jogador);
                        }

                    }

                    return jogadores;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;
                }
            }
        }
    }
}
