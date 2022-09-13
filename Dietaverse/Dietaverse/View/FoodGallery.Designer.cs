namespace Dietaverse.View
{
    partial class FoodGallery
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.adNewPhotoButton = new System.Windows.Forms.Button();
            this.galleryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(572, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(136, 396);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Recipes will apear here...";
            // 
            // adNewPhotoButton
            // 
            this.adNewPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adNewPhotoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adNewPhotoButton.ForeColor = System.Drawing.Color.Coral;
            this.adNewPhotoButton.Location = new System.Drawing.Point(599, 12);
            this.adNewPhotoButton.Name = "adNewPhotoButton";
            this.adNewPhotoButton.Size = new System.Drawing.Size(109, 37);
            this.adNewPhotoButton.TabIndex = 12;
            this.adNewPhotoButton.Text = "Add new";
            this.adNewPhotoButton.UseVisualStyleBackColor = true;
            this.adNewPhotoButton.Click += new System.EventHandler(this.adNewPhotoButton_Click);
            // 
            // galleryPanel
            // 
            this.galleryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.galleryPanel.Location = new System.Drawing.Point(29, 69);
            this.galleryPanel.Name = "galleryPanel";
            this.galleryPanel.Size = new System.Drawing.Size(517, 396);
            this.galleryPanel.TabIndex = 14;
            // 
            // FoodGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.galleryPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.adNewPhotoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodGallery";
            this.Text = "FoodGallery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button adNewPhotoButton;
        private System.Windows.Forms.FlowLayoutPanel galleryPanel;
    }
}