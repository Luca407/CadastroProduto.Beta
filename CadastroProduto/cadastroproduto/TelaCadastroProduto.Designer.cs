namespace cadastroproduto
{
    partial class TelaCadastroProduto
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
            txtPesquisar = new TextBox();
            label1 = new Label();
            btnPesquisar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEditar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            mtxtPreco = new MaskedTextBox();
            cbCategoria = new ComboBox();
            txtNomeProduto = new TextBox();
            dgvProduto = new DataGridView();
            lblNomeUsuario = new Label();
            txtQuant = new TextBox();
            lblID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(151, 37);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(247, 23);
            txtPesquisar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 40);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Pesquise aqui:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(404, 37);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 214);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 245);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(258, 245);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(258, 214);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 7;
            label5.Text = "Quantidade:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(473, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(473, 185);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(473, 243);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // mtxtPreco
            // 
            mtxtPreco.Location = new Point(347, 242);
            mtxtPreco.Mask = "0000.00";
            mtxtPreco.Name = "mtxtPreco";
            mtxtPreco.Size = new Size(53, 23);
            mtxtPreco.TabIndex = 12;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Brinquedos e Jogos", "Eletrônicos", "Vestuário e Moda", "Esportes e Lazer", "Construção", "Ferramentas" });
            cbCategoria.Location = new Point(100, 242);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(124, 23);
            cbCategoria.TabIndex = 14;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(100, 211);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(124, 23);
            txtNomeProduto.TabIndex = 15;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(12, 69);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.Size = new Size(536, 110);
            dgvProduto.TabIndex = 16;
            dgvProduto.CellDoubleClick += dgvProduto_CellDoubleClick;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(12, 9);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(97, 15);
            lblNomeUsuario.TabIndex = 17;
            lblNomeUsuario.Text = "nome do usuario";
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(347, 211);
            txtQuant.MaxLength = 10000;
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(53, 23);
            txtQuant.TabIndex = 18;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 189);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 19;
            lblID.Text = "ID do produto selecionado: 0";
            // 
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblID);
            Controls.Add(txtQuant);
            Controls.Add(lblNomeUsuario);
            Controls.Add(dgvProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(cbCategoria);
            Controls.Add(mtxtPreco);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(label1);
            Name = "TelaCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroProduto";
            FormClosed += TelaCadastroProduto_FormClosed;
            Load += TelaCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisar;
        private Label label1;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEditar;
        private Button btnCadastrar;
        private Button btnExcluir;
        private MaskedTextBox mtxtPreco;
        private TextBox textBox1;
        private ComboBox cbCategoria;
        private TextBox txtNomeProduto;
        private DataGridView dgvProduto;
        private Label lblNomeUsuario;
        private TextBox txtQuant;
        private Label lblID;
    }
}