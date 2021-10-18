
namespace ProjetoFuncionario
{
    partial class FrmFuncionario
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
            this.cmdAddFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.labelmostra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelmaiorSalario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdFecharMaior = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.cmdLimpar);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmdGravar);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 337);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdAddFunc
            // 
            this.cmdAddFunc.Location = new System.Drawing.Point(1, 12);
            this.cmdAddFunc.Name = "cmdAddFunc";
            this.cmdAddFunc.Size = new System.Drawing.Size(474, 39);
            this.cmdAddFunc.TabIndex = 1;
            this.cmdAddFunc.Text = "Adicionar Funcionario";
            this.cmdAddFunc.UseVisualStyleBackColor = true;
            this.cmdAddFunc.Click += new System.EventHandler(this.cmdAddFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o sálario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Adimissão :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(155, 107);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(201, 22);
            this.txtSalario.TabIndex = 4;
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(12, 253);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(192, 49);
            this.cmdGravar.TabIndex = 6;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(491, 12);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(450, 45);
            this.cmdMostrar.TabIndex = 2;
            this.cmdMostrar.Text = "MostrarFuncionario";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelmostra);
            this.panel2.Controls.Add(this.cmdFechar);
            this.panel2.Location = new System.Drawing.Point(491, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 337);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(91, 270);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(288, 49);
            this.cmdFechar.TabIndex = 7;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // labelmostra
            // 
            this.labelmostra.AutoSize = true;
            this.labelmostra.Location = new System.Drawing.Point(3, 61);
            this.labelmostra.Name = "labelmostra";
            this.labelmostra.Size = new System.Drawing.Size(0, 17);
            this.labelmostra.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastrando Funcionario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Funcionarios";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(156, 160);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(261, 22);
            this.dtp1.TabIndex = 8;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(226, 253);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(207, 49);
            this.cmdLimpar.TabIndex = 9;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Funcionario com maior Salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelmaiorSalario
            // 
            this.labelmaiorSalario.AutoSize = true;
            this.labelmaiorSalario.Location = new System.Drawing.Point(15, 9);
            this.labelmaiorSalario.Name = "labelmaiorSalario";
            this.labelmaiorSalario.Size = new System.Drawing.Size(0, 17);
            this.labelmaiorSalario.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.cmdFecharMaior);
            this.panel3.Controls.Add(this.labelmaiorSalario);
            this.panel3.Location = new System.Drawing.Point(302, 523);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 138);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cmdFecharMaior
            // 
            this.cmdFecharMaior.Location = new System.Drawing.Point(18, 86);
            this.cmdFecharMaior.Name = "cmdFecharMaior";
            this.cmdFecharMaior.Size = new System.Drawing.Size(288, 49);
            this.cmdFecharMaior.TabIndex = 8;
            this.cmdFecharMaior.Text = "Fechar";
            this.cmdFecharMaior.UseVisualStyleBackColor = true;
            this.cmdFecharMaior.Click += new System.EventHandler(this.cmdFecharMaior_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdAddFunc);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFuncionario";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdAddFunc;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Label labelmostra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelmaiorSalario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdFecharMaior;
    }
}

