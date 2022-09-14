
namespace Secure_Email_Application.User_Controls
{
    partial class EncryptDecryptText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptDecryptText));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnDecrypt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnEncrypt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnCopyText = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnGeneratePassword = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtText = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bgwEncrypt = new System.ComponentModel.BackgroundWorker();
            this.bgwDecrypt = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.AllowAnimations = true;
            this.btnDecrypt.AllowMouseEffects = true;
            this.btnDecrypt.AllowToggling = false;
            this.btnDecrypt.AnimationSpeed = 200;
            this.btnDecrypt.AutoGenerateColors = false;
            this.btnDecrypt.AutoRoundBorders = false;
            this.btnDecrypt.AutoSizeLeftIcon = true;
            this.btnDecrypt.AutoSizeRightIcon = true;
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.BackgroundImage")));
            this.btnDecrypt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDecrypt.ButtonText = "Decrypt";
            this.btnDecrypt.ButtonTextMarginLeft = 0;
            this.btnDecrypt.ColorContrastOnClick = 45;
            this.btnDecrypt.ColorContrastOnHover = 45;
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDecrypt.CustomizableEdges = borderEdges1;
            this.btnDecrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecrypt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDecrypt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDecrypt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDecrypt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrypt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDecrypt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDecrypt.IconMarginLeft = 11;
            this.btnDecrypt.IconPadding = 10;
            this.btnDecrypt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecrypt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDecrypt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDecrypt.IconSize = 25;
            this.btnDecrypt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.IdleBorderRadius = 30;
            this.btnDecrypt.IdleBorderThickness = 1;
            this.btnDecrypt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.IdleIconLeftImage = null;
            this.btnDecrypt.IdleIconRightImage = null;
            this.btnDecrypt.IndicateFocus = false;
            this.btnDecrypt.Location = new System.Drawing.Point(185, 695);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDecrypt.OnDisabledState.BorderRadius = 30;
            this.btnDecrypt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDecrypt.OnDisabledState.BorderThickness = 1;
            this.btnDecrypt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDecrypt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDecrypt.OnDisabledState.IconLeftImage = null;
            this.btnDecrypt.OnDisabledState.IconRightImage = null;
            this.btnDecrypt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDecrypt.onHoverState.BorderRadius = 30;
            this.btnDecrypt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDecrypt.onHoverState.BorderThickness = 1;
            this.btnDecrypt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDecrypt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.onHoverState.IconLeftImage = null;
            this.btnDecrypt.onHoverState.IconRightImage = null;
            this.btnDecrypt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.OnIdleState.BorderRadius = 30;
            this.btnDecrypt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDecrypt.OnIdleState.BorderThickness = 1;
            this.btnDecrypt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrypt.OnIdleState.IconLeftImage = null;
            this.btnDecrypt.OnIdleState.IconRightImage = null;
            this.btnDecrypt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.OnPressedState.BorderRadius = 30;
            this.btnDecrypt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDecrypt.OnPressedState.BorderThickness = 1;
            this.btnDecrypt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDecrypt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.OnPressedState.IconLeftImage = null;
            this.btnDecrypt.OnPressedState.IconRightImage = null;
            this.btnDecrypt.Size = new System.Drawing.Size(150, 40);
            this.btnDecrypt.TabIndex = 40;
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDecrypt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecrypt.TextMarginLeft = 0;
            this.btnDecrypt.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDecrypt.UseDefaultRadiusAndThickness = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AllowAnimations = true;
            this.btnEncrypt.AllowMouseEffects = true;
            this.btnEncrypt.AllowToggling = false;
            this.btnEncrypt.AnimationSpeed = 200;
            this.btnEncrypt.AutoGenerateColors = false;
            this.btnEncrypt.AutoRoundBorders = false;
            this.btnEncrypt.AutoSizeLeftIcon = true;
            this.btnEncrypt.AutoSizeRightIcon = true;
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.BackgroundImage")));
            this.btnEncrypt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEncrypt.ButtonText = "Encrypt";
            this.btnEncrypt.ButtonTextMarginLeft = 0;
            this.btnEncrypt.ColorContrastOnClick = 45;
            this.btnEncrypt.ColorContrastOnHover = 45;
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEncrypt.CustomizableEdges = borderEdges2;
            this.btnEncrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEncrypt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEncrypt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEncrypt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEncrypt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncrypt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEncrypt.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEncrypt.IconMarginLeft = 11;
            this.btnEncrypt.IconPadding = 10;
            this.btnEncrypt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncrypt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEncrypt.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEncrypt.IconSize = 25;
            this.btnEncrypt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.IdleBorderRadius = 30;
            this.btnEncrypt.IdleBorderThickness = 1;
            this.btnEncrypt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.IdleIconLeftImage = null;
            this.btnEncrypt.IdleIconRightImage = null;
            this.btnEncrypt.IndicateFocus = false;
            this.btnEncrypt.Location = new System.Drawing.Point(25, 695);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEncrypt.OnDisabledState.BorderRadius = 30;
            this.btnEncrypt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEncrypt.OnDisabledState.BorderThickness = 1;
            this.btnEncrypt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEncrypt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEncrypt.OnDisabledState.IconLeftImage = null;
            this.btnEncrypt.OnDisabledState.IconRightImage = null;
            this.btnEncrypt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEncrypt.onHoverState.BorderRadius = 30;
            this.btnEncrypt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEncrypt.onHoverState.BorderThickness = 1;
            this.btnEncrypt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEncrypt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.onHoverState.IconLeftImage = null;
            this.btnEncrypt.onHoverState.IconRightImage = null;
            this.btnEncrypt.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.OnIdleState.BorderRadius = 30;
            this.btnEncrypt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEncrypt.OnIdleState.BorderThickness = 1;
            this.btnEncrypt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncrypt.OnIdleState.IconLeftImage = null;
            this.btnEncrypt.OnIdleState.IconRightImage = null;
            this.btnEncrypt.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.OnPressedState.BorderRadius = 30;
            this.btnEncrypt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEncrypt.OnPressedState.BorderThickness = 1;
            this.btnEncrypt.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEncrypt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.OnPressedState.IconLeftImage = null;
            this.btnEncrypt.OnPressedState.IconRightImage = null;
            this.btnEncrypt.Size = new System.Drawing.Size(150, 40);
            this.btnEncrypt.TabIndex = 41;
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEncrypt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEncrypt.TextMarginLeft = 0;
            this.btnEncrypt.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEncrypt.UseDefaultRadiusAndThickness = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(55, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(248, 30);
            this.bunifuLabel1.TabIndex = 45;
            this.bunifuLabel1.Text = "Encrypt and Decrypt Text";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 5;
            this.btnBack.ImageSize = new System.Drawing.Size(23, 20);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(28, 25);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(20, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(28, 25);
            this.btnBack.TabIndex = 44;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 5;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(25, 678);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(880, 10);
            this.bunifuSeparator3.TabIndex = 47;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(25, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(880, 10);
            this.bunifuSeparator1.TabIndex = 48;
            // 
            // btnCopyText
            // 
            this.btnCopyText.AllowAnimations = true;
            this.btnCopyText.AllowMouseEffects = true;
            this.btnCopyText.AllowToggling = false;
            this.btnCopyText.AnimationSpeed = 200;
            this.btnCopyText.AutoGenerateColors = false;
            this.btnCopyText.AutoRoundBorders = false;
            this.btnCopyText.AutoSizeLeftIcon = true;
            this.btnCopyText.AutoSizeRightIcon = true;
            this.btnCopyText.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyText.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyText.BackgroundImage")));
            this.btnCopyText.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCopyText.ButtonText = "Copy text";
            this.btnCopyText.ButtonTextMarginLeft = 0;
            this.btnCopyText.ColorContrastOnClick = 45;
            this.btnCopyText.ColorContrastOnHover = 45;
            this.btnCopyText.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCopyText.CustomizableEdges = borderEdges3;
            this.btnCopyText.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCopyText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCopyText.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCopyText.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCopyText.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCopyText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyText.ForeColor = System.Drawing.Color.White;
            this.btnCopyText.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyText.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyText.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCopyText.IconMarginLeft = 11;
            this.btnCopyText.IconPadding = 10;
            this.btnCopyText.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyText.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyText.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCopyText.IconSize = 25;
            this.btnCopyText.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.IdleBorderRadius = 30;
            this.btnCopyText.IdleBorderThickness = 1;
            this.btnCopyText.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.IdleIconLeftImage = null;
            this.btnCopyText.IdleIconRightImage = null;
            this.btnCopyText.IndicateFocus = false;
            this.btnCopyText.Location = new System.Drawing.Point(345, 695);
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCopyText.OnDisabledState.BorderRadius = 30;
            this.btnCopyText.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCopyText.OnDisabledState.BorderThickness = 1;
            this.btnCopyText.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCopyText.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCopyText.OnDisabledState.IconLeftImage = null;
            this.btnCopyText.OnDisabledState.IconRightImage = null;
            this.btnCopyText.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnCopyText.onHoverState.BorderRadius = 30;
            this.btnCopyText.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCopyText.onHoverState.BorderThickness = 1;
            this.btnCopyText.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnCopyText.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCopyText.onHoverState.IconLeftImage = null;
            this.btnCopyText.onHoverState.IconRightImage = null;
            this.btnCopyText.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.OnIdleState.BorderRadius = 30;
            this.btnCopyText.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCopyText.OnIdleState.BorderThickness = 1;
            this.btnCopyText.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCopyText.OnIdleState.IconLeftImage = null;
            this.btnCopyText.OnIdleState.IconRightImage = null;
            this.btnCopyText.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.OnPressedState.BorderRadius = 30;
            this.btnCopyText.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCopyText.OnPressedState.BorderThickness = 1;
            this.btnCopyText.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnCopyText.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCopyText.OnPressedState.IconLeftImage = null;
            this.btnCopyText.OnPressedState.IconRightImage = null;
            this.btnCopyText.Size = new System.Drawing.Size(150, 40);
            this.btnCopyText.TabIndex = 49;
            this.btnCopyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopyText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCopyText.TextMarginLeft = 0;
            this.btnCopyText.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCopyText.UseDefaultRadiusAndThickness = true;
            this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(26, 128);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(880, 10);
            this.bunifuSeparator2.TabIndex = 51;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 30;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 7;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(25, 82);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(814, 40);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 52;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.AllowAnimations = true;
            this.btnGeneratePassword.AllowMouseEffects = true;
            this.btnGeneratePassword.AllowToggling = false;
            this.btnGeneratePassword.AnimationSpeed = 200;
            this.btnGeneratePassword.AutoGenerateColors = false;
            this.btnGeneratePassword.AutoRoundBorders = false;
            this.btnGeneratePassword.AutoSizeLeftIcon = true;
            this.btnGeneratePassword.AutoSizeRightIcon = true;
            this.btnGeneratePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneratePassword.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGeneratePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneratePassword.BackgroundImage")));
            this.btnGeneratePassword.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.ButtonText = "";
            this.btnGeneratePassword.ButtonTextMarginLeft = 0;
            this.btnGeneratePassword.ColorContrastOnClick = 45;
            this.btnGeneratePassword.ColorContrastOnHover = 45;
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnGeneratePassword.CustomizableEdges = borderEdges4;
            this.btnGeneratePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGeneratePassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGeneratePassword.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.IconLeft = global::Secure_Email_Application.Properties.Resources.Login_Lock;
            this.btnGeneratePassword.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGeneratePassword.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGeneratePassword.IconMarginLeft = 11;
            this.btnGeneratePassword.IconPadding = 7;
            this.btnGeneratePassword.IconRight = null;
            this.btnGeneratePassword.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGeneratePassword.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGeneratePassword.IconSize = 25;
            this.btnGeneratePassword.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.IdleBorderRadius = 0;
            this.btnGeneratePassword.IdleBorderThickness = 0;
            this.btnGeneratePassword.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.IdleIconLeftImage = global::Secure_Email_Application.Properties.Resources.Login_Lock;
            this.btnGeneratePassword.IdleIconRightImage = null;
            this.btnGeneratePassword.IndicateFocus = false;
            this.btnGeneratePassword.Location = new System.Drawing.Point(845, 82);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGeneratePassword.OnDisabledState.BorderRadius = 30;
            this.btnGeneratePassword.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.OnDisabledState.BorderThickness = 1;
            this.btnGeneratePassword.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGeneratePassword.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGeneratePassword.OnDisabledState.IconLeftImage = null;
            this.btnGeneratePassword.OnDisabledState.IconRightImage = null;
            this.btnGeneratePassword.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnGeneratePassword.onHoverState.BorderRadius = 30;
            this.btnGeneratePassword.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.onHoverState.BorderThickness = 1;
            this.btnGeneratePassword.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnGeneratePassword.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.onHoverState.IconLeftImage = null;
            this.btnGeneratePassword.onHoverState.IconRightImage = null;
            this.btnGeneratePassword.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnGeneratePassword.OnIdleState.BorderRadius = 30;
            this.btnGeneratePassword.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.OnIdleState.BorderThickness = 1;
            this.btnGeneratePassword.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnGeneratePassword.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.OnIdleState.IconLeftImage = global::Secure_Email_Application.Properties.Resources.Login_Lock;
            this.btnGeneratePassword.OnIdleState.IconRightImage = null;
            this.btnGeneratePassword.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnGeneratePassword.OnPressedState.BorderRadius = 30;
            this.btnGeneratePassword.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.OnPressedState.BorderThickness = 1;
            this.btnGeneratePassword.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnGeneratePassword.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.OnPressedState.IconLeftImage = null;
            this.btnGeneratePassword.OnPressedState.IconRightImage = null;
            this.btnGeneratePassword.Size = new System.Drawing.Size(60, 40);
            this.btnGeneratePassword.TabIndex = 53;
            this.btnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGeneratePassword.TextMarginLeft = 0;
            this.btnGeneratePassword.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGeneratePassword.UseDefaultRadiusAndThickness = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtText
            // 
            this.txtText.AcceptsReturn = false;
            this.txtText.AcceptsTab = false;
            this.txtText.AnimationSpeed = 200;
            this.txtText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtText.AutoSizeHeight = true;
            this.txtText.BackColor = System.Drawing.Color.Transparent;
            this.txtText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtText.BackgroundImage")));
            this.txtText.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtText.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtText.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtText.BorderRadius = 30;
            this.txtText.BorderThickness = 1;
            this.txtText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.DefaultFont = new System.Drawing.Font("Segoe UI", 13F);
            this.txtText.DefaultText = "";
            this.txtText.FillColor = System.Drawing.Color.White;
            this.txtText.ForeColor = System.Drawing.Color.Black;
            this.txtText.HideSelection = true;
            this.txtText.IconLeft = null;
            this.txtText.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.IconPadding = 7;
            this.txtText.IconRight = null;
            this.txtText.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.Lines = new string[0];
            this.txtText.Location = new System.Drawing.Point(25, 144);
            this.txtText.MaxLength = 32767;
            this.txtText.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtText.Modified = false;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtText.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtText.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtText.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtText.OnIdleState = stateProperties8;
            this.txtText.Padding = new System.Windows.Forms.Padding(3);
            this.txtText.PasswordChar = '\0';
            this.txtText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtText.PlaceholderText = "Text";
            this.txtText.ReadOnly = false;
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.ShortcutsEnabled = true;
            this.txtText.Size = new System.Drawing.Size(881, 528);
            this.txtText.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtText.TabIndex = 54;
            this.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtText.TextMarginBottom = 0;
            this.txtText.TextMarginLeft = 3;
            this.txtText.TextMarginTop = 1;
            this.txtText.TextPlaceholder = "Text";
            this.txtText.UseSystemPasswordChar = false;
            this.txtText.WordWrap = true;
            // 
            // bgwEncrypt
            // 
            this.bgwEncrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEncrypt_DoWork);
            this.bgwEncrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEncrypt_RunWorkerCompleted);
            // 
            // bgwDecrypt
            // 
            this.bgwDecrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDecrypt_DoWork);
            this.bgwDecrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDecrypt_RunWorkerCompleted);
            // 
            // EncryptDecryptText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.btnCopyText);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Name = "EncryptDecryptText";
            this.Size = new System.Drawing.Size(935, 750);
            this.Load += new System.EventHandler(this.EncryptDecryptText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDecrypt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEncrypt;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCopyText;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGeneratePassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtText;
        private System.ComponentModel.BackgroundWorker bgwEncrypt;
        private System.ComponentModel.BackgroundWorker bgwDecrypt;
    }
}
