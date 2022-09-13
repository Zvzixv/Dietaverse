namespace Dietaverse.View
{
    partial class AddNewFoodPhoto
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
            this.notetextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.choosephotobutton = new System.Windows.Forms.Button();
            this.adNewPhotoButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notetextBox
            // 
            this.notetextBox.Location = new System.Drawing.Point(51, 48);
            this.notetextBox.Multiline = true;
            this.notetextBox.Name = "notetextBox";
            this.notetextBox.Size = new System.Drawing.Size(100, 83);
            this.notetextBox.TabIndex = 66;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(40, 244);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(271, 148);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 67;
            this.pictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(122, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Nie wybrano zdjęcia";
            // 
            // choosephotobutton
            // 
            this.choosephotobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosephotobutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.choosephotobutton.ForeColor = System.Drawing.Color.Coral;
            this.choosephotobutton.Location = new System.Drawing.Point(343, 303);
            this.choosephotobutton.Name = "choosephotobutton";
            this.choosephotobutton.Size = new System.Drawing.Size(102, 29);
            this.choosephotobutton.TabIndex = 69;
            this.choosephotobutton.Text = "Dodaj zdjęcie";
            this.choosephotobutton.UseVisualStyleBackColor = true;
            this.choosephotobutton.Click += new System.EventHandler(this.choosephotobutton_Click_1);
            // 
            // adNewPhotoButton
            // 
            this.adNewPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adNewPhotoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adNewPhotoButton.ForeColor = System.Drawing.Color.Coral;
            this.adNewPhotoButton.Location = new System.Drawing.Point(533, 295);
            this.adNewPhotoButton.Name = "adNewPhotoButton";
            this.adNewPhotoButton.Size = new System.Drawing.Size(109, 37);
            this.adNewPhotoButton.TabIndex = 70;
            this.adNewPhotoButton.Text = "Add new";
            this.adNewPhotoButton.UseVisualStyleBackColor = true;
            this.adNewPhotoButton.Click += new System.EventHandler(this.adNewPhotoButton_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddNewFoodPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.adNewPhotoButton);
            this.Controls.Add(this.choosephotobutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.notetextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewFoodPhoto";
            this.Text = "AddNewFoodPhoto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notetextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button choosephotobutton;
        private System.Windows.Forms.Button adNewPhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}