
namespace Projeto_02
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdLaranja = new System.Windows.Forms.Button();
            this.cmdMorango = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdLaranja
            // 
            this.cmdLaranja.Location = new System.Drawing.Point(391, 43);
            this.cmdLaranja.Name = "cmdLaranja";
            this.cmdLaranja.Size = new System.Drawing.Size(75, 23);
            this.cmdLaranja.TabIndex = 1;
            this.cmdLaranja.Text = "Laranja";
            this.cmdLaranja.UseVisualStyleBackColor = true;
            this.cmdLaranja.Click += new System.EventHandler(this.cmdLaranja_Click);
            // 
            // cmdMorango
            // 
            this.cmdMorango.Location = new System.Drawing.Point(391, 154);
            this.cmdMorango.Name = "cmdMorango";
            this.cmdMorango.Size = new System.Drawing.Size(75, 23);
            this.cmdMorango.TabIndex = 2;
            this.cmdMorango.Text = "Morango";
            this.cmdMorango.UseVisualStyleBackColor = true;
            this.cmdMorango.Click += new System.EventHandler(this.cmdMorango_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdMorango);
            this.Controls.Add(this.cmdLaranja);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdLaranja;
        private System.Windows.Forms.Button cmdMorango;
    }
}

