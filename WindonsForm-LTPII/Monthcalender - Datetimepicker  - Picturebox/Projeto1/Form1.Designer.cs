
namespace Projeto1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDateTimePicker = new System.Windows.Forms.Label();
            this.lblMonthCalender = new System.Windows.Forms.Label();
            this.cmdok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(315, 70);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lblDateTimePicker
            // 
            this.lblDateTimePicker.AutoSize = true;
            this.lblDateTimePicker.Location = new System.Drawing.Point(84, 131);
            this.lblDateTimePicker.Name = "lblDateTimePicker";
            this.lblDateTimePicker.Size = new System.Drawing.Size(0, 15);
            this.lblDateTimePicker.TabIndex = 2;
            // 
            // lblMonthCalender
            // 
            this.lblMonthCalender.AutoSize = true;
            this.lblMonthCalender.Location = new System.Drawing.Point(315, 241);
            this.lblMonthCalender.Name = "lblMonthCalender";
            this.lblMonthCalender.Size = new System.Drawing.Size(0, 15);
            this.lblMonthCalender.TabIndex = 3;
            // 
            // cmdok
            // 
            this.cmdok.Location = new System.Drawing.Point(637, 72);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(75, 23);
            this.cmdok.TabIndex = 4;
            this.cmdok.Text = "OK";
            this.cmdok.UseVisualStyleBackColor = true;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdok);
            this.Controls.Add(this.lblMonthCalender);
            this.Controls.Add(this.lblDateTimePicker);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDateTimePicker;
        private System.Windows.Forms.Label lblMonthCalender;
        private System.Windows.Forms.Button cmdok;
    }
}

