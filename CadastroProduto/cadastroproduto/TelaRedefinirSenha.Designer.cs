namespace cadastroproduto
{
    partial class TelaRedefinirSenha
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
            txtConfirmarSenha = new TextBox();
            btnSalvar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtNovaSenha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmarSenha);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNovaSenha);
            groupBox1.Location = new Point(89, 33);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(355, 203);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(191, 96);
            txtConfirmarSenha.Margin = new Padding(2);
            txtConfirmarSenha.MaxLength = 50;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(106, 23);
            txtConfirmarSenha.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.ImeMode = ImeMode.NoControl;
            btnSalvar.Location = new Point(136, 136);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 20);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(39, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 17);
            label3.TabIndex = 5;
            label3.Text = "Confirmar Nova Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(39, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Nova Senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(191, 55);
            txtNovaSenha.Margin = new Padding(2);
            txtNovaSenha.MaxLength = 50;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(106, 23);
            txtNovaSenha.TabIndex = 1;
            // 
            // TelaRedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(groupBox1);
            Name = "TelaRedefinirSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaRedefinirSenha";
            
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private Label label3;
        private Label label2;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarSenha;
    }
}