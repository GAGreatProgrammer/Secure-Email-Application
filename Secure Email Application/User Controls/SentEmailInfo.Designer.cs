
namespace Secure_Email_Application.User_Controls
{
    partial class SentEmailInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentEmailInfo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblDateTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTo = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnIndicator = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AllowParentOverrides = false;
            this.lblDateTime.AutoEllipsis = false;
            this.lblDateTime.AutoSize = false;
            this.lblDateTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(210, 15);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateTime.Size = new System.Drawing.Size(80, 34);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "Data";
            this.lblDateTime.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblDateTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTo
            // 
            this.lblTo.AllowParentOverrides = false;
            this.lblTo.AutoEllipsis = false;
            this.lblTo.AutoSize = false;
            this.lblTo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(48, 17);
            this.lblTo.Name = "lblTo";
            this.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTo.Size = new System.Drawing.Size(161, 25);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "Data";
            this.lblTo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnIndicator
            // 
            this.btnIndicator.AllowAnimations = true;
            this.btnIndicator.AllowMouseEffects = true;
            this.btnIndicator.AllowToggling = false;
            this.btnIndicator.AnimationSpeed = 200;
            this.btnIndicator.AutoGenerateColors = false;
            this.btnIndicator.AutoRoundBorders = false;
            this.btnIndicator.AutoSizeLeftIcon = true;
            this.btnIndicator.AutoSizeRightIcon = true;
            this.btnIndicator.BackColor = System.Drawing.Color.Transparent;
            this.btnIndicator.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIndicator.BackgroundImage")));
            this.btnIndicator.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIndicator.ButtonText = "";
            this.btnIndicator.ButtonTextMarginLeft = 0;
            this.btnIndicator.ColorContrastOnClick = 45;
            this.btnIndicator.ColorContrastOnHover = 45;
            this.btnIndicator.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = false;
            this.btnIndicator.CustomizableEdges = borderEdges1;
            this.btnIndicator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIndicator.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIndicator.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIndicator.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIndicator.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnIndicator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIndicator.ForeColor = System.Drawing.Color.White;
            this.btnIndicator.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndicator.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIndicator.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIndicator.IconMarginLeft = 11;
            this.btnIndicator.IconPadding = 10;
            this.btnIndicator.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIndicator.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIndicator.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIndicator.IconSize = 25;
            this.btnIndicator.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnIndicator.IdleBorderRadius = 10;
            this.btnIndicator.IdleBorderThickness = 1;
            this.btnIndicator.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIndicator.IdleIconLeftImage = null;
            this.btnIndicator.IdleIconRightImage = null;
            this.btnIndicator.IndicateFocus = false;
            this.btnIndicator.Location = new System.Drawing.Point(13, 17);
            this.btnIndicator.Name = "btnIndicator";
            this.btnIndicator.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIndicator.OnDisabledState.BorderRadius = 10;
            this.btnIndicator.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIndicator.OnDisabledState.BorderThickness = 1;
            this.btnIndicator.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIndicator.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIndicator.OnDisabledState.IconLeftImage = null;
            this.btnIndicator.OnDisabledState.IconRightImage = null;
            this.btnIndicator.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIndicator.onHoverState.BorderRadius = 10;
            this.btnIndicator.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIndicator.onHoverState.BorderThickness = 1;
            this.btnIndicator.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIndicator.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnIndicator.onHoverState.IconLeftImage = null;
            this.btnIndicator.onHoverState.IconRightImage = null;
            this.btnIndicator.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnIndicator.OnIdleState.BorderRadius = 10;
            this.btnIndicator.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIndicator.OnIdleState.BorderThickness = 1;
            this.btnIndicator.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIndicator.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnIndicator.OnIdleState.IconLeftImage = null;
            this.btnIndicator.OnIdleState.IconRightImage = null;
            this.btnIndicator.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnIndicator.OnPressedState.BorderRadius = 10;
            this.btnIndicator.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIndicator.OnPressedState.BorderThickness = 1;
            this.btnIndicator.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnIndicator.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnIndicator.OnPressedState.IconLeftImage = null;
            this.btnIndicator.OnPressedState.IconRightImage = null;
            this.btnIndicator.Size = new System.Drawing.Size(25, 25);
            this.btnIndicator.TabIndex = 4;
            this.btnIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIndicator.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIndicator.TextMarginLeft = 0;
            this.btnIndicator.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIndicator.UseDefaultRadiusAndThickness = true;
            // 
            // SentEmailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnIndicator);
            this.Name = "SentEmailInfo";
            this.Size = new System.Drawing.Size(305, 60);
            this.Load += new System.EventHandler(this.SentEmailInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuLabel lblDateTime;
        private Bunifu.UI.WinForms.BunifuLabel lblTo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnIndicator;
    }
}
