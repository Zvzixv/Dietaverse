namespace Dietaverse.View
{
    partial class MonthSummary
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.kcalLabel = new System.Windows.Forms.Label();
            this.datelabelOut = new System.Windows.Forms.Label();
            this.weightlabelOut = new System.Windows.Forms.Label();
            this.callabelOut = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuText;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(96, 82);
            this.monthCalendar1.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Coral;
            this.dateLabel.Location = new System.Drawing.Point(17, 18);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(78, 30);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Data:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.Coral;
            this.weightLabel.Location = new System.Drawing.Point(17, 48);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(91, 30);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Waga:";
            // 
            // kcalLabel
            // 
            this.kcalLabel.AutoSize = true;
            this.kcalLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcalLabel.ForeColor = System.Drawing.Color.Coral;
            this.kcalLabel.Location = new System.Drawing.Point(17, 78);
            this.kcalLabel.Name = "kcalLabel";
            this.kcalLabel.Size = new System.Drawing.Size(101, 30);
            this.kcalLabel.TabIndex = 6;
            this.kcalLabel.Text = "Kalorie:";
            // 
            // datelabelOut
            // 
            this.datelabelOut.AutoSize = true;
            this.datelabelOut.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabelOut.ForeColor = System.Drawing.Color.Coral;
            this.datelabelOut.Location = new System.Drawing.Point(101, 18);
            this.datelabelOut.Name = "datelabelOut";
            this.datelabelOut.Size = new System.Drawing.Size(26, 30);
            this.datelabelOut.TabIndex = 6;
            this.datelabelOut.Text = "0";
            // 
            // weightlabelOut
            // 
            this.weightlabelOut.AutoSize = true;
            this.weightlabelOut.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightlabelOut.ForeColor = System.Drawing.Color.Coral;
            this.weightlabelOut.Location = new System.Drawing.Point(114, 48);
            this.weightlabelOut.Name = "weightlabelOut";
            this.weightlabelOut.Size = new System.Drawing.Size(26, 30);
            this.weightlabelOut.TabIndex = 6;
            this.weightlabelOut.Text = "0";
            // 
            // callabelOut
            // 
            this.callabelOut.AutoSize = true;
            this.callabelOut.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callabelOut.ForeColor = System.Drawing.Color.Coral;
            this.callabelOut.Location = new System.Drawing.Point(127, 78);
            this.callabelOut.Name = "callabelOut";
            this.callabelOut.Size = new System.Drawing.Size(26, 30);
            this.callabelOut.TabIndex = 6;
            this.callabelOut.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Coral;
            this.richTextBox1.Location = new System.Drawing.Point(410, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 125);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.datelabelOut);
            this.panel1.Controls.Add(this.kcalLabel);
            this.panel1.Controls.Add(this.weightlabelOut);
            this.panel1.Controls.Add(this.weightLabel);
            this.panel1.Controls.Add(this.callabelOut);
            this.panel1.Location = new System.Drawing.Point(96, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 125);
            this.panel1.TabIndex = 8;
            // 
            // MonthSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthSummary";
            this.Text = "MonthSummary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label kcalLabel;
        private System.Windows.Forms.Label datelabelOut;
        private System.Windows.Forms.Label weightlabelOut;
        private System.Windows.Forms.Label callabelOut;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
    }
}