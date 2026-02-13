namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEnviar = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cbxNota = new ComboBox();
            txtTempo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cbxPlataforma = new ComboBox();
            label8 = new Label();
            txtJogo = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            txtNacionalidade = new TextBox();
            label5 = new Label();
            cbxGenero = new ComboBox();
            label4 = new Label();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            btnAtualizar = new Button();
            dgvJogador = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJogador).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(9, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(709, 514);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(btnEnviar);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(701, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(192, 255, 192);
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.Font = new Font("Segoe UI", 12F);
            btnEnviar.Location = new Point(319, 447);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(77, 29);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(260, 226);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 3;
            label2.Text = "Avaliação de Jogo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(307, 3);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 2;
            label1.Text = "Jogador";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(cbxNota);
            panel2.Controls.Add(txtTempo);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cbxPlataforma);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtJogo);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(9, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 182);
            panel2.TabIndex = 1;
            // 
            // cbxNota
            // 
            cbxNota.Cursor = Cursors.Hand;
            cbxNota.FormattingEnabled = true;
            cbxNota.Location = new Point(498, 87);
            cbxNota.Name = "cbxNota";
            cbxNota.Size = new Size(121, 23);
            cbxNota.TabIndex = 18;
            // 
            // txtTempo
            // 
            txtTempo.Cursor = Cursors.IBeam;
            txtTempo.Location = new Point(375, 87);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(402, 69);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 16;
            label10.Text = "Tempo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(249, 69);
            label9.Name = "label9";
            label9.Size = new Size(67, 17);
            label9.TabIndex = 13;
            label9.Text = "Plataforma";
            // 
            // cbxPlataforma
            // 
            cbxPlataforma.Cursor = Cursors.Hand;
            cbxPlataforma.FormattingEnabled = true;
            cbxPlataforma.Location = new Point(220, 87);
            cbxPlataforma.Name = "cbxPlataforma";
            cbxPlataforma.Size = new Size(121, 23);
            cbxPlataforma.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(538, 69);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 14;
            label8.Text = "Nota";
            // 
            // txtJogo
            // 
            txtJogo.Cursor = Cursors.IBeam;
            txtJogo.Location = new Point(82, 86);
            txtJogo.Name = "txtJogo";
            txtJogo.Size = new Size(100, 23);
            txtJogo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(114, 68);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 12;
            label7.Text = "Jogo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNacionalidade);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbxGenero);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(6, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 182);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(507, 67);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 11;
            label6.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Cursor = Cursors.IBeam;
            txtNacionalidade.Location = new Point(501, 86);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(100, 23);
            txtNacionalidade.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(394, 67);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 9;
            label5.Text = "Gênero";
            // 
            // cbxGenero
            // 
            cbxGenero.Cursor = Cursors.Hand;
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Location = new Point(357, 86);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(121, 23);
            cbxGenero.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(254, 67);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 7;
            label4.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Cursor = Cursors.IBeam;
            txtIdade.Location = new Point(223, 86);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(85, 86);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(117, 67);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 4;
            label3.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAtualizar);
            tabPage2.Controls.Add(dgvJogador);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(701, 486);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Resultados";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(255, 255, 192);
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(302, 436);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(85, 29);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dgvJogador
            // 
            dgvJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogador.Location = new Point(6, 6);
            dgvJogador.Name = "dgvJogador";
            dgvJogador.Size = new Size(689, 414);
            dgvJogador.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 531);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJogador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private Panel panel1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbxGenero;
        private Label label6;
        private TextBox txtNacionalidade;
        private TextBox txtTempo;
        private Label label10;
        private Label label9;
        private ComboBox cbxPlataforma;
        private Label label8;
        private TextBox txtJogo;
        private Label label7;
        private ComboBox cbxNota;
        private Button btnEnviar;
        private Button btnAtualizar;
        private DataGridView dgvJogador;
    }
}
