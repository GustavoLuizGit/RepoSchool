
namespace Projeto_3
{
    partial class CadastroForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cmdimg1 = new System.Windows.Forms.Button();
            this.cmdimg2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(220, 28);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 23);
            this.txtnome.TabIndex = 1;
            // 
            // cmdimg1
            // 
            this.cmdimg1.Location = new System.Drawing.Point(83, 84);
            this.cmdimg1.Name = "cmdimg1";
            this.cmdimg1.Size = new System.Drawing.Size(75, 23);
            this.cmdimg1.TabIndex = 2;
            this.cmdimg1.Text = "Imagem 1 ";
            this.cmdimg1.UseVisualStyleBackColor = true;
            this.cmdimg1.Click += new System.EventHandler(this.cmdimg1_Click);
            // 
            // cmdimg2
            // 
            this.cmdimg2.Location = new System.Drawing.Point(287, 84);
            this.cmdimg2.Name = "cmdimg2";
            this.cmdimg2.Size = new System.Drawing.Size(75, 23);
            this.cmdimg2.TabIndex = 3;
            this.cmdimg2.Text = "Imagem 2 ";
            this.cmdimg2.UseVisualStyleBackColor = true;
            this.cmdimg2.Click += new System.EventHandler(this.cmdimg2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(245, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdCadastro
            // 
            this.cmdCadastro.Location = new System.Drawing.Point(175, 281);
            this.cmdCadastro.Name = "cmdCadastro";
            this.cmdCadastro.Size = new System.Drawing.Size(75, 23);
            this.cmdCadastro.TabIndex = 6;
            this.cmdCadastro.Text = "Cadastro";
            this.cmdCadastro.UseVisualStyleBackColor = true;
            this.cmdCadastro.Click += new System.EventHandler(this.cmdCadastro_Click);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCadastro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdimg2);
            this.Controls.Add(this.cmdimg1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroForm";
            this.Text = "CadastroForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button cmdimg1;
        private System.Windows.Forms.Button cmdimg2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdCadastro;
    }
}