namespace cadastroproduto
{
    partial class TelaCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtCadSenha = new TextBox();
            txtCadUsuario = new TextBox();
            txtCadEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mtxtCadCpf = new MaskedTextBox();
            btnCadastrar = new Button();
            txtCadNome = new TextBox();
            btnVoltar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCadSenha);
            groupBox1.Controls.Add(txtCadUsuario);
            groupBox1.Controls.Add(txtCadEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtxtCadCpf);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCadNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(86, 16);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(388, 218);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 60);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "E-mail";
            // 
            // txtCadSenha
            // 
            txtCadSenha.Location = new Point(120, 140);
            txtCadSenha.Margin = new Padding(2);
            txtCadSenha.MaxLength = 8;
            txtCadSenha.Name = "txtCadSenha";
            txtCadSenha.Size = new Size(106, 23);
            txtCadSenha.TabIndex = 9;
            // 
            // txtCadUsuario
            // 
            txtCadUsuario.Location = new Point(120, 112);
            txtCadUsuario.Margin = new Padding(2);
            txtCadUsuario.Name = "txtCadUsuario";
            txtCadUsuario.Size = new Size(106, 23);
            txtCadUsuario.TabIndex = 8;
            // 
            // txtCadEmail
            // 
            txtCadEmail.Location = new Point(120, 58);
            txtCadEmail.Margin = new Padding(2);
            txtCadEmail.Name = "txtCadEmail";
            txtCadEmail.Size = new Size(204, 23);
            txtCadEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 116);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 140);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // mtxtCadCpf
            // 
            mtxtCadCpf.Location = new Point(120, 86);
            mtxtCadCpf.Margin = new Padding(2);
            mtxtCadCpf.Mask = "000.000.000-00";
            mtxtCadCpf.Name = "mtxtCadCpf";
            mtxtCadCpf.Size = new Size(106, 23);
            mtxtCadCpf.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(162, 170);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 20);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCadNome
            // 
            txtCadNome.Location = new Point(120, 32);
            txtCadNome.Margin = new Padding(2);
            txtCadNome.Name = "txtCadNome";
            txtCadNome.Size = new Size(204, 23);
            txtCadNome.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(8, 242);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(78, 20);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnVoltar);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastre-se";
            FormClosed += TelaCadastro_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnCadastrar;
        private TextBox txtCadNome;
        private MaskedTextBox mtxtCadCpf;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtCadSenha;
        private TextBox txtCadUsuario;
        private TextBox txtCadEmail;
        private Button btnVoltar;
    }
}