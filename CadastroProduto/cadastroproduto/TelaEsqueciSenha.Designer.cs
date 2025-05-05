namespace cadastroproduto
{
    partial class TelaEsqueciSenha
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
            groupBox1 = new GroupBox();
            mtxtCpf = new MaskedTextBox();
            btnAvancar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            btnVoltar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtCpf);
            groupBox1.Controls.Add(btnAvancar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(158, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(244, 203);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Location = new Point(101, 95);
            mtxtCpf.Mask = "000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(91, 23);
            mtxtCpf.TabIndex = 8;
            // 
            // btnAvancar
            // 
            btnAvancar.ImeMode = ImeMode.NoControl;
            btnAvancar.Location = new Point(88, 136);
            btnAvancar.Margin = new Padding(2);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(78, 20);
            btnAvancar.TabIndex = 7;
            btnAvancar.Text = "Avançar";
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Click += btnAvancar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(40, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(40, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 55);
            txtEmail.Margin = new Padding(2);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(106, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 235);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaEsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnVoltar);
            Controls.Add(groupBox1);
            Name = "TelaEsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueci Senha";
            FormClosed += TelaEsqueciSenha_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAvancar;
        private Label label3;
        private Label label2;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private MaskedTextBox mtxtCpf;
        private Button btnVoltar;
    }
}