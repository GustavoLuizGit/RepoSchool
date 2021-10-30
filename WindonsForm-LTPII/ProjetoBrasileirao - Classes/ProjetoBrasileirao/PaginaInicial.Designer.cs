
namespace ProjetoBrasileirao
{
    partial class PaginaInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdAdicionar = new System.Windows.Forms.Button();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdPesquisaNome = new System.Windows.Forms.Button();
            this.PesquisaData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BackgroundImage = global::ProjetoBrasileirao.Properties.Resources._20190423182944_861;
            this.panel1.Controls.Add(this.cmdExcluir);
            this.panel1.Controls.Add(this.cmdAlterar);
            this.panel1.Controls.Add(this.cmdAdicionar);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 131);
            this.panel1.TabIndex = 1;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.Green;
            this.cmdExcluir.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.Location = new System.Drawing.Point(101, 36);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(211, 73);
            this.cmdExcluir.TabIndex = 3;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.BackColor = System.Drawing.Color.Green;
            this.cmdAlterar.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.cmdAlterar.Location = new System.Drawing.Point(825, 36);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(211, 73);
            this.cmdAlterar.TabIndex = 2;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = false;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.BackColor = System.Drawing.Color.Green;
            this.cmdAdicionar.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdicionar.Location = new System.Drawing.Point(479, 36);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(211, 73);
            this.cmdAdicionar.TabIndex = 0;
            this.cmdAdicionar.Text = "Adicionar time";
            this.cmdAdicionar.UseVisualStyleBackColor = false;
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.BackColor = System.Drawing.Color.ForestGreen;
            this.cmdPesquisar.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPesquisar.Location = new System.Drawing.Point(468, 490);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(211, 73);
            this.cmdPesquisar.TabIndex = 1;
            this.cmdPesquisar.Text = "Pesquisar ";
            this.cmdPesquisar.UseVisualStyleBackColor = false;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdPesquisaNome
            // 
            this.cmdPesquisaNome.BackColor = System.Drawing.Color.Green;
            this.cmdPesquisaNome.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPesquisaNome.Location = new System.Drawing.Point(264, 13);
            this.cmdPesquisaNome.Name = "cmdPesquisaNome";
            this.cmdPesquisaNome.Size = new System.Drawing.Size(211, 87);
            this.cmdPesquisaNome.TabIndex = 3;
            this.cmdPesquisaNome.Text = "Nome";
            this.cmdPesquisaNome.UseVisualStyleBackColor = false;
            this.cmdPesquisaNome.Click += new System.EventHandler(this.cmdPesquisaNome_Click);
            // 
            // PesquisaData
            // 
            this.PesquisaData.BackColor = System.Drawing.Color.Green;
            this.PesquisaData.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaData.Location = new System.Drawing.Point(689, 13);
            this.PesquisaData.Name = "PesquisaData";
            this.PesquisaData.Size = new System.Drawing.Size(211, 87);
            this.PesquisaData.TabIndex = 4;
            this.PesquisaData.Text = "Data de fundação";
            this.PesquisaData.UseVisualStyleBackColor = false;
            this.PesquisaData.Click += new System.EventHandler(this.PesquisaData_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImage = global::ProjetoBrasileirao.Properties.Resources._20190423182944_861;
            this.panel2.Controls.Add(this.cmdPesquisaNome);
            this.panel2.Controls.Add(this.PesquisaData);
            this.panel2.Location = new System.Drawing.Point(-4, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 113);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoBrasileirao.Properties.Resources.classificacao_brasileirao_541x338;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1118, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PaginaInicial";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdAdicionar;
        private System.Windows.Forms.Button cmdPesquisaNome;
        private System.Windows.Forms.Button PesquisaData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdExcluir;
    }
}

