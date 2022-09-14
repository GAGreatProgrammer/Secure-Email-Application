
namespace Secure_Email_Application.User_Controls
{
    partial class ShowAttachmentPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAttachmentPanel));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFile = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Secure_Email_Application.Properties.Resources.File;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFile
            // 
            this.lblFile.AllowParentOverrides = false;
            this.lblFile.AutoEllipsis = false;
            this.lblFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFile.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.lblFile.Location = new System.Drawing.Point(55, 16);
            this.lblFile.Name = "lblFile";
            this.lblFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFile.Size = new System.Drawing.Size(70, 25);
            this.lblFile.TabIndex = 5;
            this.lblFile.Text = "Test.jpg";
            this.lblFile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ShowAttachmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFile);
            this.Name = "ShowAttachmentPanel";
            this.Size = new System.Drawing.Size(180, 60);
            this.Load += new System.EventHandler(this.ShowAttachmentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblFile;
    }
}
