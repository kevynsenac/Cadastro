using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gênero
            cbxGenero.Items.Add("Masculino");
            cbxGenero.Items.Add("Feminino");
            // Plataforma
            cbxPlataforma.Items.Add("PlayStation");
            cbxPlataforma.Items.Add("Xbox");
            cbxPlataforma.Items.Add("Nintendo");
            cbxPlataforma.Items.Add("Computador");
            cbxPlataforma.Items.Add("Celular");
            // Nota
            cbxNota.Items.Add("10");
            cbxNota.Items.Add("9");
            cbxNota.Items.Add("8");
            cbxNota.Items.Add("7");
            cbxNota.Items.Add("6");
            cbxNota.Items.Add("5");
            cbxNota.Items.Add("4");
            cbxNota.Items.Add("3");
            cbxNota.Items.Add("2");
            cbxNota.Items.Add("1");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Validacao())
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Jogador jogador = new Jogador();
            jogador.Nome = txtNome.Text;
            jogador.Idade = Convert.ToInt32(txtIdade.Text);
            jogador.Genero = cbxGenero.SelectedItem.ToString();
            jogador.Nacionalidade = txtNacionalidade.Text;
            jogador.Jogos.Nome = txtJogo.Text;
            jogador.Jogos.Plataforma = Convert.ToString(cbxPlataforma.Text);
            jogador.Jogos.Tempo = Convert.ToInt32(txtTempo.Text);
            jogador.Jogos.Nota = Convert.ToInt32(cbxNota.Text);

            BancoDeDados.InserirJogador(jogador);

            MessageBox.Show("Jogador Cadastrado!");

            txtJogo.Text = txtTempo.Text = string.Empty;
            cbxPlataforma.SelectedIndex = cbxNota.SelectedIndex;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvJogador.DataSource = BancoDeDados.BuscaJogador();
            dgvJogador.Update();
        }

        private bool Validacao()
        {
            if(string.IsNullOrEmpty(txtNome.Text)) 
                return false;
            if(string.IsNullOrEmpty(txtIdade.Text))
                return false;
            if (cbxGenero.SelectedIndex == -1)
                return false;
            if(string.IsNullOrEmpty(txtNacionalidade.Text))
                return false;
            if(string.IsNullOrEmpty(txtJogo.Text))
                return false;
            if (cbxPlataforma.SelectedIndex == -1)
                return false;
            if (string.IsNullOrEmpty(txtTempo.Text))
                return false;
            if (cbxNota.SelectedIndex == -1)
                return false;
            return true;
        }
    }
}