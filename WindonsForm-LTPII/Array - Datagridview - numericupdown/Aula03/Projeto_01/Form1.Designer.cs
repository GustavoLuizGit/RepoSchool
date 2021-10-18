
namespace Projeto_01
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
            this.nudlinhas = new System.Windows.Forms.NumericUpDown();
            this.nudcolunas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvmatriz = new System.Windows.Forms.DataGridView();
            this.cmdmatriz = new System.Windows.Forms.Button();
            this.cmdSoma = new System.Windows.Forms.Button();
            this.lblsoma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudlinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcolunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // nudlinhas
            // 
            this.nudlinhas.Location = new System.Drawing.Point(173, 64);
            this.nudlinhas.Name = "nudlinhas";
            this.nudlinhas.Size = new System.Drawing.Size(120, 23);
            this.nudlinhas.TabIndex = 0;
            // 
            // nudcolunas
            // 
            this.nudcolunas.Location = new System.Drawing.Point(173, 127);
            this.nudcolunas.Name = "nudcolunas";
            this.nudcolunas.Size = new System.Drawing.Size(120, 23);
            this.nudcolunas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linhas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colunas : ";
            // 
            // dgvmatriz
            // 
            this.dgvmatriz.AllowUserToAddRows = false;
            this.dgvmatriz.AllowUserToDeleteRows = false;
            this.dgvmatriz.AllowUserToResizeColumns = false;
            this.dgvmatriz.AllowUserToResizeRows = false;
            this.dgvmatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatriz.ColumnHeadersVisible = false;
            this.dgvmatriz.Location = new System.Drawing.Point(346, 64);
            this.dgvmatriz.Name = "dgvmatriz";
            this.dgvmatriz.RowHeadersVisible = false;
            this.dgvmatriz.RowTemplate.Height = 25;
            this.dgvmatriz.Size = new System.Drawing.Size(240, 150);
            this.dgvmatriz.TabIndex = 4;
            // 
            // cmdmatriz
            // 
            this.cmdmatriz.Location = new System.Drawing.Point(80, 183);
            this.cmdmatriz.Name = "cmdmatriz";
            this.cmdmatriz.Size = new System.Drawing.Size(75, 23);
            this.cmdmatriz.TabIndex = 5;
            this.cmdmatriz.Text = "Matriz";
            this.cmdmatriz.UseVisualStyleBackColor = true;
            this.cmdmatriz.Click += new System.EventHandler(this.cmdmatriz_Click);
            // 
            // cmdSoma
            // 
            this.cmdSoma.Location = new System.Drawing.Point(80, 237);
            this.cmdSoma.Name = "cmdSoma";
            this.cmdSoma.Size = new System.Drawing.Size(75, 23);
            this.cmdSoma.TabIndex = 6;
            this.cmdSoma.Text = "Soma";
            this.cmdSoma.UseVisualStyleBackColor = true;
            this.cmdSoma.Click += new System.EventHandler(this.cmdSoma_Click);
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Location = new System.Drawing.Point(228, 241);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(37, 15);
            this.lblsoma.TabIndex = 7;
            this.lblsoma.Text = "Soma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.cmdSoma);
            this.Controls.Add(this.cmdmatriz);
            this.Controls.Add(this.dgvmatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudcolunas);
            this.Controls.Add(this.nudlinhas);
            this.Name = "Form1";
            this.Text = "b";
            ((System.ComponentModel.ISupportInitialize)(this.nudlinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcolunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudlinhas;
        private System.Windows.Forms.NumericUpDown nudcolunas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvmatriz;
        private System.Windows.Forms.Button cmdmatriz;
        private System.Windows.Forms.Button cmdSoma;
        private System.Windows.Forms.Label lblsoma;
    }
}

