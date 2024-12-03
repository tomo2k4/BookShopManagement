namespace BookShopManagement
{
    partial class Loading
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
            lblTieuDe = new Label();
            lblLoad = new Label();
            picGd = new PictureBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)picGd).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Roboto", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(176, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(460, 44);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Hệ thống quản lý bán sách";
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Font = new Font("Roboto", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoad.Location = new Point(12, 405);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(164, 41);
            lblLoad.TabIndex = 1;
            lblLoad.Text = "Loading...";
            // 
            // picGd
            // 
            picGd.Image = Properties.Resources.Quanly;
            picGd.Location = new Point(191, 56);
            picGd.Name = "picGd";
            picGd.Size = new Size(416, 345);
            picGd.SizeMode = PictureBoxSizeMode.StretchImage;
            picGd.TabIndex = 2;
            picGd.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 449);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 29);
            progressBar1.TabIndex = 3;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 507);
            Controls.Add(progressBar1);
            Controls.Add(picGd);
            Controls.Add(lblLoad);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += this.Loading_Load;
            ((System.ComponentModel.ISupportInitialize)picGd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblLoad;
        private PictureBox picGd;
        private ProgressBar progressBar1;
    }
}
