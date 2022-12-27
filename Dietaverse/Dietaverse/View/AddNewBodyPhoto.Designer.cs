namespace Dietaverse.View
{
    partial class AddNewBodyPhoto
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
            this.adNewPhotoButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.notetextBox = new System.Windows.Forms.TextBox();
            this.choosephotobutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adNewPhotoButton
            // 
            this.adNewPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adNewPhotoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adNewPhotoButton.ForeColor = System.Drawing.Color.Coral;
            this.adNewPhotoButton.Location = new System.Drawing.Point(553, 393);
            this.adNewPhotoButton.Name = "adNewPhotoButton";
            this.adNewPhotoButton.Size = new System.Drawing.Size(109, 37);
            this.adNewPhotoButton.TabIndex = 10;
            this.adNewPhotoButton.Text = "Dodaj";
            this.adNewPhotoButton.UseVisualStyleBackColor = true;
            this.adNewPhotoButton.Click += new System.EventHandler(this.adNewPhotoButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(20, 194);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(179, 207);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 62;
            this.pictureBox.TabStop = false;
            // 
            // notetextBox
            // 
            this.notetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.notetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notetextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notetextBox.ForeColor = System.Drawing.Color.Coral;
            this.notetextBox.Location = new System.Drawing.Point(20, 17);
            this.notetextBox.Multiline = true;
            this.notetextBox.Name = "notetextBox";
            this.notetextBox.Size = new System.Drawing.Size(262, 112);
            this.notetextBox.TabIndex = 65;
            this.notetextBox.Enter += new System.EventHandler(this.notetextBox_Enter);
            this.notetextBox.Leave += new System.EventHandler(this.notetextBox_Leave);
            // 
            // choosephotobutton
            // 
            this.choosephotobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosephotobutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.choosephotobutton.ForeColor = System.Drawing.Color.Coral;
            this.choosephotobutton.Location = new System.Drawing.Point(263, 281);
            this.choosephotobutton.Name = "choosephotobutton";
            this.choosephotobutton.Size = new System.Drawing.Size(102, 29);
            this.choosephotobutton.TabIndex = 66;
            this.choosephotobutton.Text = "Dodaj zdjęcie";
            this.choosephotobutton.UseVisualStyleBackColor = true;
            this.choosephotobutton.Click += new System.EventHandler(this.choosephotobutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.choosephotobutton);
            this.panel1.Controls.Add(this.notetextBox);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(32, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 418);
            this.panel1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(223, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 79);
            this.label2.TabIndex = 66;
            this.label2.Text = "Zdecydowanie zalecane jest dodanie pionowego zdjęcia 1500x2101, które jest mniejs" +
    "ze niż 50 kB.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(54, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nie wybrano zdjęcia";
            // 
            // backbutton
            // 
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Coral;
            this.backbutton.Location = new System.Drawing.Point(553, 339);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(109, 37);
            this.backbutton.TabIndex = 10;
            this.backbutton.Text = "Powrót";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddNewBodyPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.adNewPhotoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewBodyPhoto";
            this.Text = "AddNewBodyPhoto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adNewPhotoButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox notetextBox;
        private System.Windows.Forms.Button choosephotobutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label2;
    }
}