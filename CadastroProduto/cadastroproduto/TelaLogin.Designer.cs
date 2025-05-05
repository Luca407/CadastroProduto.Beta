namespace cadastroproduto
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            groupBox1 = new GroupBox();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            llblCadastro = new LinkLabel();
            llblEsqueciSenha = new LinkLabel();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(llblCadastro);
            groupBox1.Controls.Add(llblEsqueciSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            resources.ApplyResources(btnEntrar, "btnEntrar");
            btnEntrar.Name = "btnEntrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // llblCadastro
            // 
            resources.ApplyResources(llblCadastro, "llblCadastro");
            llblCadastro.Name = "llblCadastro";
            llblCadastro.TabStop = true;
            llblCadastro.LinkClicked += llblCadastro_LinkClicked;
            // 
            // llblEsqueciSenha
            // 
            resources.ApplyResources(llblEsqueciSenha, "llblEsqueciSenha");
            llblEsqueciSenha.Name = "llblEsqueciSenha";
            llblEsqueciSenha.TabStop = true;
            llblEsqueciSenha.LinkClicked += llblEsqueciSenha_LinkClicked;
            // 
            // txtSenha
            // 
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            // 
            // TelaLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "TelaLogin";
            FormClosed += TelaLogin_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private LinkLabel llblCadastro;
        private LinkLabel llblEsqueciSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Button btnEntrar;
    }
}
