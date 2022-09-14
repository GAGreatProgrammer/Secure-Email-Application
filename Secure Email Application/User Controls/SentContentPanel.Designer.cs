
namespace Secure_Email_Application.User_Controls
{
    partial class SentContentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentContentPanel));
            this.SentEmailsContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.SuspendLayout();
            // 
            // SentEmailsContentPanel
            // 
            this.SentEmailsContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SentEmailsContentPanel.Location = new System.Drawing.Point(0, 0);
            this.SentEmailsContentPanel.Name = "SentEmailsContentPanel";
            this.SentEmailsContentPanel.Size = new System.Drawing.Size(315, 570);
            this.SentEmailsContentPanel.TabIndex = 19;
            // 
            // ScrollBar
            // 
            this.ScrollBar.AllowCursorChanges = true;
            this.ScrollBar.AllowHomeEndKeysDetection = false;
            this.ScrollBar.AllowIncrementalClickMoves = true;
            this.ScrollBar.AllowMouseDownEffects = true;
            this.ScrollBar.AllowMouseHoverEffects = true;
            this.ScrollBar.AllowScrollingAnimations = true;
            this.ScrollBar.AllowScrollKeysDetection = true;
            this.ScrollBar.AllowScrollOptionsMenu = true;
            this.ScrollBar.AllowShrinkingOnFocusLost = false;
            this.ScrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScrollBar.BackgroundImage")));
            this.ScrollBar.BindingContainer = null;
            this.ScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ScrollBar.BorderRadius = 10;
            this.ScrollBar.BorderThickness = 1;
            this.ScrollBar.DurationBeforeShrink = 2000;
            this.ScrollBar.LargeChange = 10;
            this.ScrollBar.Location = new System.Drawing.Point(320, 0);
            this.ScrollBar.Maximum = 100;
            this.ScrollBar.Minimum = 0;
            this.ScrollBar.MinimumThumbLength = 18;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.ScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.ScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.ScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ScrollBar.ShrinkSizeLimit = 3;
            this.ScrollBar.Size = new System.Drawing.Size(13, 570);
            this.ScrollBar.SmallChange = 1;
            this.ScrollBar.TabIndex = 20;
            this.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ScrollBar.ThumbLength = 56;
            this.ScrollBar.ThumbMargin = 1;
            this.ScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.ScrollBar.Value = 0;
            this.ScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.ScrollBar_Scroll);
            // 
            // SentContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.SentEmailsContentPanel);
            this.Name = "SentContentPanel";
            this.Size = new System.Drawing.Size(335, 575);
            this.Load += new System.EventHandler(this.SentContentPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SentEmailsContentPanel;
        private Bunifu.UI.WinForms.BunifuVScrollBar ScrollBar;
    }
}
