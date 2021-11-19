
namespace ProjetoAgenda
{
    partial class frmRelatorio
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
            this.cmdVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdVisualizar
            // 
            this.cmdVisualizar.Location = new System.Drawing.Point(172, 124);
            this.cmdVisualizar.Name = "cmdVisualizar";
            this.cmdVisualizar.Size = new System.Drawing.Size(420, 197);
            this.cmdVisualizar.TabIndex = 0;
            this.cmdVisualizar.Text = "Visualizar ";
            this.cmdVisualizar.UseVisualStyleBackColor = true;
            this.cmdVisualizar.Click += new System.EventHandler(this.cmdVisualizar_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdVisualizar);
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdVisualizar;
    }
}