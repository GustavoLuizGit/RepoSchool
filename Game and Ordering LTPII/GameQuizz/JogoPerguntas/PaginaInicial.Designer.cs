
namespace JogoPerguntas
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRank = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFechr = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQuizz = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRank,
            this.mnuRegra,
            this.mnuFechr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuRank
            // 
            this.mnuRank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuRank.Name = "mnuRank";
            this.mnuRank.Size = new System.Drawing.Size(76, 24);
            this.mnuRank.Text = "Ranking";
            this.mnuRank.Click += new System.EventHandler(this.mnuRank_Click);
            // 
            // mnuRegra
            // 
            this.mnuRegra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuRegra.Name = "mnuRegra";
            this.mnuRegra.Size = new System.Drawing.Size(68, 24);
            this.mnuRegra.Text = "Regras";
            this.mnuRegra.Click += new System.EventHandler(this.mnuRegra_Click);
            // 
            // mnuFechr
            // 
            this.mnuFechr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuFechr.Name = "mnuFechr";
            this.mnuFechr.Size = new System.Drawing.Size(59, 24);
            this.mnuFechr.Text = "Close";
            this.mnuFechr.Click += new System.EventHandler(this.mnuFechr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoPerguntas.Properties.Resources.Jogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Divirta-se e aprenda jogando um jogo sobre c#");
            // 
            // cmdQuizz
            // 
            this.cmdQuizz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdQuizz.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdQuizz.Location = new System.Drawing.Point(396, 553);
            this.cmdQuizz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdQuizz.Name = "cmdQuizz";
            this.cmdQuizz.Size = new System.Drawing.Size(176, 37);
            this.cmdQuizz.TabIndex = 2;
            this.cmdQuizz.Text = "Jogar";
            this.cmdQuizz.UseVisualStyleBackColor = false;
            this.cmdQuizz.Click += new System.EventHandler(this.cmdQuizz_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(422, 518);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Digite seu nome";
            this.txtName.Size = new System.Drawing.Size(133, 27);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdSalvar.Location = new System.Drawing.Point(396, 598);
            this.cmdSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(176, 37);
            this.cmdSalvar.TabIndex = 4;
            this.cmdSalvar.Text = "Salvar Jogo";
            this.cmdSalvar.UseVisualStyleBackColor = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quizz Computação";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdQuizz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaInicial";
            this.Text = "Bora Jogar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRank;
        private System.Windows.Forms.ToolStripMenuItem mnuRegra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQuizz;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem mnuFechr;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

