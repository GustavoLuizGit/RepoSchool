
namespace ProjetoFuncionario
{
    partial class Departamento
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelmostra = new System.Windows.Forms.Label();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdAddDepartamento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelmostra);
            this.panel2.Controls.Add(this.cmdFechar);
            this.panel2.Location = new System.Drawing.Point(502, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 337);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Departamento";
            // 
            // labelmostra
            // 
            this.labelmostra.AutoSize = true;
            this.labelmostra.Location = new System.Drawing.Point(3, 61);
            this.labelmostra.Name = "labelmostra";
            this.labelmostra.Size = new System.Drawing.Size(0, 17);
            this.labelmostra.TabIndex = 8;
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
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(502, 12);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(450, 45);
            this.cmdMostrar.TabIndex = 10;
            this.cmdMostrar.Text = "Mostrar Departamento";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // cmdAddDepartamento
            // 
            this.cmdAddDepartamento.Location = new System.Drawing.Point(12, 12);
            this.cmdAddDepartamento.Name = "cmdAddDepartamento";
            this.cmdAddDepartamento.Size = new System.Drawing.Size(474, 39);
            this.cmdAddDepartamento.TabIndex = 9;
            this.cmdAddDepartamento.Text = "Adicionar Departamento";
            this.cmdAddDepartamento.UseVisualStyleBackColor = true;
            this.cmdAddDepartamento.Click += new System.EventHandler(this.cmdAddDepartamento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.cmdLimpar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmdGravar);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 337);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(240, 239);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(207, 49);
            this.cmdLimpar.TabIndex = 9;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastrando Departamento";
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(22, 239);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(192, 49);
            this.cmdGravar.TabIndex = 6;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(156, 161);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(200, 22);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 22);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o codigo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome :";
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdAddDepartamento);
            this.Controls.Add(this.panel1);
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelmostra;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button cmdAddDepartamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}