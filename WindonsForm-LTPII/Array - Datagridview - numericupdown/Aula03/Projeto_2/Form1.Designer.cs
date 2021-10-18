
namespace Projeto_2
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
            this.cmdvetor = new System.Windows.Forms.Button();
            this.dgvmatriz = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nudcolunas = new System.Windows.Forms.NumericUpDown();
            this.cmdquicksort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcolunas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdvetor
            // 
            this.cmdvetor.Location = new System.Drawing.Point(85, 106);
            this.cmdvetor.Name = "cmdvetor";
            this.cmdvetor.Size = new System.Drawing.Size(75, 23);
            this.cmdvetor.TabIndex = 13;
            this.cmdvetor.Text = "Vetor";
            this.cmdvetor.UseVisualStyleBackColor = true;
            this.cmdvetor.Click += new System.EventHandler(this.cmdvetor_Click);
            // 
            // dgvmatriz
            // 
            this.dgvmatriz.AllowUserToAddRows = false;
            this.dgvmatriz.AllowUserToDeleteRows = false;
            this.dgvmatriz.AllowUserToResizeColumns = false;
            this.dgvmatriz.AllowUserToResizeRows = false;
            this.dgvmatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatriz.ColumnHeadersVisible = false;
            this.dgvmatriz.Location = new System.Drawing.Point(355, 53);
            this.dgvmatriz.Name = "dgvmatriz";
            this.dgvmatriz.RowHeadersVisible = false;
            this.dgvmatriz.RowTemplate.Height = 25;
            this.dgvmatriz.Size = new System.Drawing.Size(254, 53);
            this.dgvmatriz.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Colunas : ";
            // 
            // nudcolunas
            // 
            this.nudcolunas.Location = new System.Drawing.Point(161, 53);
            this.nudcolunas.Name = "nudcolunas";
            this.nudcolunas.Size = new System.Drawing.Size(120, 23);
            this.nudcolunas.TabIndex = 9;
            // 
            // cmdquicksort
            // 
            this.cmdquicksort.Location = new System.Drawing.Point(368, 121);
            this.cmdquicksort.Name = "cmdquicksort";
            this.cmdquicksort.Size = new System.Drawing.Size(75, 23);
            this.cmdquicksort.TabIndex = 14;
            this.cmdquicksort.Text = "QuickSort";
            this.cmdquicksort.UseVisualStyleBackColor = true;
            this.cmdquicksort.Click += new System.EventHandler(this.cmdquicksort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdquicksort);
            this.Controls.Add(this.cmdvetor);
            this.Controls.Add(this.dgvmatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudcolunas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcolunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdvetor;
        private System.Windows.Forms.DataGridView dgvmatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudcolunas;
        private System.Windows.Forms.Button cmdquicksort;
    }
}

