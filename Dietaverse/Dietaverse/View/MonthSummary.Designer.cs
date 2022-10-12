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
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
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
            this.dateLabel.Location = new System.Drawing.Point(170, 287);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(78, 30);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.Coral;
            this.weightLabel.Location = new System.Drawing.Point(170, 317);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(104, 30);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Weight:";
            // 
            // kcalLabel
            // 
            this.kcalLabel.AutoSize = true;
            this.kcalLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcalLabel.ForeColor = System.Drawing.Color.Coral;
            this.kcalLabel.Location = new System.Drawing.Point(170, 347);
            this.kcalLabel.Name = "kcalLabel";
            this.kcalLabel.Size = new System.Drawing.Size(117, 30);
            this.kcalLabel.TabIndex = 6;
            this.kcalLabel.Text = "Calories:";
            // 
            // datelabelOut
            // 
            this.datelabelOut.AutoSize = true;
            this.datelabelOut.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabelOut.ForeColor = System.Drawing.Color.Coral;
            this.datelabelOut.Location = new System.Drawing.Point(254, 287);
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
            this.weightlabelOut.Location = new System.Drawing.Point(280, 317);
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
            this.callabelOut.Location = new System.Drawing.Point(293, 347);
            this.callabelOut.Name = "callabelOut";
            this.callabelOut.Size = new System.Drawing.Size(26, 30);
            this.callabelOut.TabIndex = 6;
            this.callabelOut.Text = "0";
            // 
            // MonthSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.kcalLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.callabelOut);
            this.Controls.Add(this.weightlabelOut);
            this.Controls.Add(this.datelabelOut);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthSummary";
            this.Text = "MonthSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label kcalLabel;
        private System.Windows.Forms.Label datelabelOut;
        private System.Windows.Forms.Label weightlabelOut;
        private System.Windows.Forms.Label callabelOut;
    }
}