
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.labelMostraNome = new System.Windows.Forms.Label();
            this.labelMostraTelefone = new System.Windows.Forms.Label();
            this.labelMostraEmail = new System.Windows.Forms.Label();
            this.labelMostraEndereco = new System.Windows.Forms.Label();
            this.buttonLimpaCampos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(61, 67);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(59, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome: ";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(126, 64);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(455, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(135, 107);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(161, 26);
            this.textBoxTelefone.TabIndex = 3;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(61, 112);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(79, 20);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone: ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(376, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(205, 26);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(323, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email: ";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(153, 152);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(428, 84);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(61, 155);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(86, 20);
            this.labelEndereco.TabIndex = 6;
            this.labelEndereco.Text = "Endereço: ";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(615, 88);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(102, 31);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(216, 282);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(122, 38);
            this.buttonAdicionar.TabIndex = 9;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Location = new System.Drawing.Point(12, 257);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(0, 20);
            this.labelMensagem.TabIndex = 19;
            // 
            // labelMostraNome
            // 
            this.labelMostraNome.AutoSize = true;
            this.labelMostraNome.Location = new System.Drawing.Point(122, 348);
            this.labelMostraNome.Name = "labelMostraNome";
            this.labelMostraNome.Size = new System.Drawing.Size(0, 20);
            this.labelMostraNome.TabIndex = 20;
            // 
            // labelMostraTelefone
            // 
            this.labelMostraTelefone.AutoSize = true;
            this.labelMostraTelefone.Location = new System.Drawing.Point(122, 394);
            this.labelMostraTelefone.Name = "labelMostraTelefone";
            this.labelMostraTelefone.Size = new System.Drawing.Size(0, 20);
            this.labelMostraTelefone.TabIndex = 21;
            // 
            // labelMostraEmail
            // 
            this.labelMostraEmail.AutoSize = true;
            this.labelMostraEmail.Location = new System.Drawing.Point(372, 394);
            this.labelMostraEmail.Name = "labelMostraEmail";
            this.labelMostraEmail.Size = new System.Drawing.Size(0, 20);
            this.labelMostraEmail.TabIndex = 22;
            // 
            // labelMostraEndereco
            // 
            this.labelMostraEndereco.AutoSize = true;
            this.labelMostraEndereco.Location = new System.Drawing.Point(122, 447);
            this.labelMostraEndereco.Name = "labelMostraEndereco";
            this.labelMostraEndereco.Size = new System.Drawing.Size(0, 20);
            this.labelMostraEndereco.TabIndex = 23;
            // 
            // buttonLimpaCampos
            // 
            this.buttonLimpaCampos.Location = new System.Drawing.Point(362, 282);
            this.buttonLimpaCampos.Name = "buttonLimpaCampos";
            this.buttonLimpaCampos.Size = new System.Drawing.Size(139, 38);
            this.buttonLimpaCampos.TabIndex = 24;
            this.buttonLimpaCampos.Text = "Limpar campos";
            this.buttonLimpaCampos.UseVisualStyleBackColor = true;
            this.buttonLimpaCampos.Click += new System.EventHandler(this.buttonLimpaCampos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(666, 166);
            this.dataGridView1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLimpaCampos);
            this.Controls.Add(this.labelMostraEndereco);
            this.Controls.Add(this.labelMostraEmail);
            this.Controls.Add(this.labelMostraTelefone);
            this.Controls.Add(this.labelMostraNome);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Label labelMostraNome;
        private System.Windows.Forms.Label labelMostraTelefone;
        private System.Windows.Forms.Label labelMostraEmail;
        private System.Windows.Forms.Label labelMostraEndereco;
        private System.Windows.Forms.Button buttonLimpaCampos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

