namespace Dietaverse.View
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.weighttextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.password2textBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(335, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register yourself";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(337, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "User name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(337, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(337, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(337, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // userNametextBox
            // 
            this.userNametextBox.Location = new System.Drawing.Point(502, 206);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(100, 20);
            this.userNametextBox.TabIndex = 3;
            // 
            // weighttextBox
            // 
            this.weighttextBox.Location = new System.Drawing.Point(502, 232);
            this.weighttextBox.Name = "weighttextBox";
            this.weighttextBox.Size = new System.Drawing.Size(100, 20);
            this.weighttextBox.TabIndex = 3;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(502, 258);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordtextBox.TabIndex = 3;
            // 
            // password2textBox
            // 
            this.password2textBox.Location = new System.Drawing.Point(502, 284);
            this.password2textBox.Name = "password2textBox";
            this.password2textBox.Size = new System.Drawing.Size(100, 20);
            this.password2textBox.TabIndex = 3;
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Coral;
            this.registerButton.Location = new System.Drawing.Point(417, 322);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(109, 37);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(898, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backbutton.ForeColor = System.Drawing.Color.Coral;
            this.backbutton.Location = new System.Drawing.Point(417, 365);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(109, 38);
            this.backbutton.TabIndex = 11;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.password2textBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.weighttextBox);
            this.Controls.Add(this.userNametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.TextBox weighttextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox password2textBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button backbutton;
    }
}