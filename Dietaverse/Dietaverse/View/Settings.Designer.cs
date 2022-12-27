namespace Dietaverse.View
{
    partial class Settings
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
            this.logoutbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pass1textBox = new System.Windows.Forms.TextBox();
            this.pass2textBox = new System.Windows.Forms.TextBox();
            this.changePasswordbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutbutton
            // 
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutbutton.ForeColor = System.Drawing.Color.Coral;
            this.logoutbutton.Location = new System.Drawing.Point(26, 25);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(109, 38);
            this.logoutbutton.TabIndex = 11;
            this.logoutbutton.Text = "Wyoguj";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(22, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Zmień hasło";
            // 
            // pass1textBox
            // 
            this.pass1textBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass1textBox.Location = new System.Drawing.Point(26, 169);
            this.pass1textBox.Name = "pass1textBox";
            this.pass1textBox.Size = new System.Drawing.Size(146, 21);
            this.pass1textBox.TabIndex = 13;
            this.pass1textBox.Text = "Wpisz nowe hasło";
            this.pass1textBox.Enter += new System.EventHandler(this.pass1textBox_Validated);
            this.pass1textBox.Leave += new System.EventHandler(this.pass1textBox_Leave);
            // 
            // pass2textBox
            // 
            this.pass2textBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass2textBox.Location = new System.Drawing.Point(26, 195);
            this.pass2textBox.Name = "pass2textBox";
            this.pass2textBox.Size = new System.Drawing.Size(146, 21);
            this.pass2textBox.TabIndex = 13;
            this.pass2textBox.Text = "Powtórz nowe hasło";
            this.pass2textBox.Enter += new System.EventHandler(this.pass2textBox_Validated);
            this.pass2textBox.Leave += new System.EventHandler(this.pass2textBox_Leave);
            // 
            // changePasswordbutton
            // 
            this.changePasswordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePasswordbutton.ForeColor = System.Drawing.Color.Coral;
            this.changePasswordbutton.Location = new System.Drawing.Point(26, 236);
            this.changePasswordbutton.Name = "changePasswordbutton";
            this.changePasswordbutton.Size = new System.Drawing.Size(109, 38);
            this.changePasswordbutton.TabIndex = 11;
            this.changePasswordbutton.Text = "Zastosuj";
            this.changePasswordbutton.UseVisualStyleBackColor = true;
            this.changePasswordbutton.Click += new System.EventHandler(this.changePasswordbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.pass2textBox);
            this.panel1.Controls.Add(this.changePasswordbutton);
            this.panel1.Controls.Add(this.pass1textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 400);
            this.panel1.TabIndex = 14;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.ForeColor = System.Drawing.Color.Coral;
            this.deleteButton.Location = new System.Drawing.Point(26, 319);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 49);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Usuń konto";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass1textBox;
        private System.Windows.Forms.TextBox pass2textBox;
        private System.Windows.Forms.Button changePasswordbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
    }
}