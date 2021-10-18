
namespace Projeto_04
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpar = new System.Windows.Forms.TextBox();
            this.txtimpar = new System.Windows.Forms.TextBox();
            this.txtPosi = new System.Windows.Forms.TextBox();
            this.txtNega = new System.Windows.Forms.TextBox();
            this.txtprimo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o número :";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(293, 40);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(150, 22);
            this.txtnumero.TabIndex = 1;
            this.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpar
            // 
            this.txtpar.Location = new System.Drawing.Point(164, 147);
            this.txtpar.Name = "txtpar";
            this.txtpar.Size = new System.Drawing.Size(100, 22);
            this.txtpar.TabIndex = 3;
            this.txtpar.Text = "Par";
            this.txtpar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtimpar
            // 
            this.txtimpar.Location = new System.Drawing.Point(333, 147);
            this.txtimpar.Name = "txtimpar";
            this.txtimpar.Size = new System.Drawing.Size(100, 22);
            this.txtimpar.TabIndex = 4;
            this.txtimpar.Text = "Impar";
            this.txtimpar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosi
            // 
            this.txtPosi.Location = new System.Drawing.Point(164, 206);
            this.txtPosi.Name = "txtPosi";
            this.txtPosi.Size = new System.Drawing.Size(100, 22);
            this.txtPosi.TabIndex = 5;
            this.txtPosi.Text = "Positivo";
            this.txtPosi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNega
            // 
            this.txtNega.Location = new System.Drawing.Point(333, 206);
            this.txtNega.Name = "txtNega";
            this.txtNega.Size = new System.Drawing.Size(100, 22);
            this.txtNega.TabIndex = 6;
            this.txtNega.Text = "Negativo";
            this.txtNega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtprimo
            // 
            this.txtprimo.Location = new System.Drawing.Point(234, 278);
            this.txtprimo.Name = "txtprimo";
            this.txtprimo.Size = new System.Drawing.Size(100, 22);
            this.txtprimo.TabIndex = 7;
            this.txtprimo.Text = "Primo";
            this.txtprimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.txtprimo);
            this.Controls.Add(this.txtNega);
            this.Controls.Add(this.txtPosi);
            this.Controls.Add(this.txtimpar);
            this.Controls.Add(this.txtpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpar;
        private System.Windows.Forms.TextBox txtimpar;
        private System.Windows.Forms.TextBox txtPosi;
        private System.Windows.Forms.TextBox txtNega;
        private System.Windows.Forms.TextBox txtprimo;
    }
}

