namespace Dietaverse
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.smoothiesButton = new System.Windows.Forms.Button();
            this.foodGalleryButton = new System.Windows.Forms.Button();
            this.bodyGalleryButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.monthButton);
            this.panel1.Controls.Add(this.smoothiesButton);
            this.panel1.Controls.Add(this.foodGalleryButton);
            this.panel1.Controls.Add(this.bodyGalleryButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.Coral;
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.Coral;
            this.settingsButton.Location = new System.Drawing.Point(0, 521);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(186, 56);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.Leave += new System.EventHandler(this.settingsButton_Leave);
            // 
            // monthButton
            // 
            this.monthButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthButton.FlatAppearance.BorderSize = 0;
            this.monthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthButton.ForeColor = System.Drawing.Color.Coral;
            this.monthButton.Image = ((System.Drawing.Image)(resources.GetObject("monthButton.Image")));
            this.monthButton.Location = new System.Drawing.Point(0, 328);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(186, 51);
            this.monthButton.TabIndex = 1;
            this.monthButton.Text = "Month summary";
            this.monthButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            this.monthButton.Leave += new System.EventHandler(this.monthButton_Leave);
            // 
            // smoothiesButton
            // 
            this.smoothiesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.smoothiesButton.FlatAppearance.BorderSize = 0;
            this.smoothiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smoothiesButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smoothiesButton.ForeColor = System.Drawing.Color.Coral;
            this.smoothiesButton.Image = ((System.Drawing.Image)(resources.GetObject("smoothiesButton.Image")));
            this.smoothiesButton.Location = new System.Drawing.Point(0, 277);
            this.smoothiesButton.Name = "smoothiesButton";
            this.smoothiesButton.Size = new System.Drawing.Size(186, 51);
            this.smoothiesButton.TabIndex = 1;
            this.smoothiesButton.Text = "Smoothies";
            this.smoothiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.smoothiesButton.UseVisualStyleBackColor = true;
            this.smoothiesButton.Click += new System.EventHandler(this.smoothiesButton_Click);
            this.smoothiesButton.Leave += new System.EventHandler(this.smoothiesButton_Leave);
            // 
            // foodGalleryButton
            // 
            this.foodGalleryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodGalleryButton.FlatAppearance.BorderSize = 0;
            this.foodGalleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodGalleryButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodGalleryButton.ForeColor = System.Drawing.Color.Coral;
            this.foodGalleryButton.Image = ((System.Drawing.Image)(resources.GetObject("foodGalleryButton.Image")));
            this.foodGalleryButton.Location = new System.Drawing.Point(0, 226);
            this.foodGalleryButton.Name = "foodGalleryButton";
            this.foodGalleryButton.Size = new System.Drawing.Size(186, 51);
            this.foodGalleryButton.TabIndex = 1;
            this.foodGalleryButton.Text = "Food gallery";
            this.foodGalleryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.foodGalleryButton.UseVisualStyleBackColor = true;
            this.foodGalleryButton.Click += new System.EventHandler(this.foodGalleryButton_Click);
            this.foodGalleryButton.Leave += new System.EventHandler(this.foodGalleryButton_Leave);
            // 
            // bodyGalleryButton
            // 
            this.bodyGalleryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodyGalleryButton.FlatAppearance.BorderSize = 0;
            this.bodyGalleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodyGalleryButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyGalleryButton.ForeColor = System.Drawing.Color.Coral;
            this.bodyGalleryButton.Image = ((System.Drawing.Image)(resources.GetObject("bodyGalleryButton.Image")));
            this.bodyGalleryButton.Location = new System.Drawing.Point(0, 175);
            this.bodyGalleryButton.Name = "bodyGalleryButton";
            this.bodyGalleryButton.Size = new System.Drawing.Size(186, 51);
            this.bodyGalleryButton.TabIndex = 1;
            this.bodyGalleryButton.Text = "Body gallery";
            this.bodyGalleryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bodyGalleryButton.UseVisualStyleBackColor = true;
            this.bodyGalleryButton.Click += new System.EventHandler(this.bodyGalleryButton_Click);
            this.bodyGalleryButton.Leave += new System.EventHandler(this.bodyGalleryButton_Leave);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.Coral;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.Location = new System.Drawing.Point(0, 124);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(186, 51);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            this.dashboardButton.Leave += new System.EventHandler(this.dashboardButton_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 124);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.Coral;
            this.lblTitle.Location = new System.Drawing.Point(220, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(914, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 477);
            this.PnlFormLoader.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dietaverse";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button smoothiesButton;
        private System.Windows.Forms.Button foodGalleryButton;
        private System.Windows.Forms.Button bodyGalleryButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Panel PnlFormLoader;
    }
}

