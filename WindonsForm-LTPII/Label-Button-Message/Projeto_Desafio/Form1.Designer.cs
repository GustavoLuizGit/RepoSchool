
namespace Projeto_Desafio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.cmdpao = new System.Windows.Forms.Button();
            this.cmdCarne = new System.Windows.Forms.Button();
            this.lblmostra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listin = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.Calorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabela De Calorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite seu nome : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite sua senha : ";
            // 
            // txtnome
            // 
            this.txtnome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnome.Location = new System.Drawing.Point(284, 50);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(150, 22);
            this.txtnome.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsenha.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtsenha.Location = new System.Drawing.Point(284, 89);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 22);
            this.txtsenha.TabIndex = 4;
            this.txtsenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtsenha_Validating);
            // 
            // cmdpao
            // 
            this.cmdpao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdpao.BackgroundImage")));
            this.cmdpao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdpao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdpao.Location = new System.Drawing.Point(88, 135);
            this.cmdpao.Name = "cmdpao";
            this.cmdpao.Size = new System.Drawing.Size(139, 105);
            this.cmdpao.TabIndex = 5;
            this.cmdpao.Text = "Pão Integral";
            this.cmdpao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdpao.UseVisualStyleBackColor = true;
            this.cmdpao.Click += new System.EventHandler(this.cmdpao_Click);
            this.cmdpao.Validating += new System.ComponentModel.CancelEventHandler(this.txtsenha_Validating);
            // 
            // cmdCarne
            // 
            this.cmdCarne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCarne.BackgroundImage")));
            this.cmdCarne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCarne.Location = new System.Drawing.Point(284, 135);
            this.cmdCarne.Name = "cmdCarne";
            this.cmdCarne.Size = new System.Drawing.Size(169, 105);
            this.cmdCarne.TabIndex = 6;
            this.cmdCarne.Text = "Carne";
            this.cmdCarne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCarne.UseVisualStyleBackColor = true;
            this.cmdCarne.Click += new System.EventHandler(this.cmdCarne_Click);
            this.cmdCarne.Validating += new System.ComponentModel.CancelEventHandler(this.txtsenha_Validating);
            // 
            // lblmostra
            // 
            this.lblmostra.AutoSize = true;
            this.lblmostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostra.ForeColor = System.Drawing.Color.Red;
            this.lblmostra.Location = new System.Drawing.Point(99, 267);
            this.lblmostra.Name = "lblmostra";
            this.lblmostra.Size = new System.Drawing.Size(84, 25);
            this.lblmostra.TabIndex = 7;
            this.lblmostra.Text = "Calorias";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = " Mostrar calorias totais:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listin
            // 
            this.listin.HideSelection = false;
            this.listin.Location = new System.Drawing.Point(580, 50);
            this.listin.Name = "listin";
            this.listin.Size = new System.Drawing.Size(121, 97);
            this.listin.TabIndex = 10;
            this.listin.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Receita Hambuguer";
            // 
            // Calorias
            // 
            this.Calorias.AutoSize = true;
            this.Calorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calorias.Location = new System.Drawing.Point(498, 221);
            this.Calorias.Name = "Calorias";
            this.Calorias.Size = new System.Drawing.Size(0, 25);
            this.Calorias.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblmostra);
            this.Controls.Add(this.cmdCarne);
            this.Controls.Add(this.cmdpao);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulário Projeto 4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button cmdpao;
        private System.Windows.Forms.Button cmdCarne;
        private System.Windows.Forms.Label lblmostra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Calorias;
    }
}

