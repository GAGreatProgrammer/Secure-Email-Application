
namespace Secure_Email_Application
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ContentPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.EncryptDecryptTextSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnEncryptDecryptText = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnLock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnSent = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnInbox = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SentSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.InboxSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.EmailInfoPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.EmailsPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblContent = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnComposeNewEmail = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnLoadFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bgwSendUserLogEmail = new System.ComponentModel.BackgroundWorker();
            this.Transition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.Transition2 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.TopPanel.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.EmailInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 60;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.TopPanel;
            this.DragControl.Vertical = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.TopPanel.BorderRadius = 0;
            this.TopPanel.BorderThickness = 0;
            this.TopPanel.Controls.Add(this.btnClose);
            this.Transition2.SetDecoration(this.TopPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.TopPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShowBorders = true;
            this.TopPanel.Size = new System.Drawing.Size(1370, 41);
            this.TopPanel.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Transition2.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::Secure_Email_Application.Properties.Resources.Close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1330, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundColor = System.Drawing.Color.White;
            this.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContentPanel.BackgroundImage")));
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.BorderColor = System.Drawing.Color.White;
            this.ContentPanel.BorderRadius = 0;
            this.ContentPanel.BorderThickness = 0;
            this.Transition2.SetDecoration(this.ContentPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.ContentPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(435, 41);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.ShowBorders = true;
            this.ContentPanel.Size = new System.Drawing.Size(935, 749);
            this.ContentPanel.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.btnSettings);
            this.bunifuPanel1.Controls.Add(this.pbIcon);
            this.bunifuPanel1.Controls.Add(this.EncryptDecryptTextSeparator);
            this.bunifuPanel1.Controls.Add(this.btnEncryptDecryptText);
            this.bunifuPanel1.Controls.Add(this.btnLock);
            this.bunifuPanel1.Controls.Add(this.btnSent);
            this.bunifuPanel1.Controls.Add(this.btnInbox);
            this.bunifuPanel1.Controls.Add(this.SentSeparator);
            this.bunifuPanel1.Controls.Add(this.InboxSeparator);
            this.bunifuPanel1.Controls.Add(this.bunifuSeparator2);
            this.bunifuPanel1.Controls.Add(this.bunifuSeparator1);
            this.Transition2.SetDecoration(this.bunifuPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.bunifuPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 38);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(90, 751);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveImage = global::Secure_Email_Application.Properties.Resources.Settings;
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowBuffering = false;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AllowZooming = true;
            this.btnSettings.AllowZoomingOnFocus = false;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Transition2.SetDecoration(this.btnSettings, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnSettings, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ErrorImage")));
            this.btnSettings.FadeWhenInactive = false;
            this.btnSettings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSettings.Image = global::Secure_Email_Application.Properties.Resources.Settings;
            this.btnSettings.ImageActive = global::Secure_Email_Application.Properties.Resources.Settings;
            this.btnSettings.ImageLocation = null;
            this.btnSettings.ImageMargin = 5;
            this.btnSettings.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSettings.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnSettings.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.InitialImage")));
            this.btnSettings.Location = new System.Drawing.Point(28, 598);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0;
            this.btnSettings.ShowActiveImage = true;
            this.btnSettings.ShowCursorChanges = true;
            this.btnSettings.ShowImageBorders = true;
            this.btnSettings.ShowSizeMarkers = false;
            this.btnSettings.Size = new System.Drawing.Size(33, 33);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.ToolTipText = "";
            this.btnSettings.WaitOnLoad = false;
            this.btnSettings.Zoom = 5;
            this.btnSettings.ZoomSpeed = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Transition1.SetDecoration(this.pbIcon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition2.SetDecoration(this.pbIcon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbIcon.Image = global::Secure_Email_Application.Properties.Resources.Icon1;
            this.pbIcon.Location = new System.Drawing.Point(17, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 60);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 18;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.pbIcon_Click);
            // 
            // EncryptDecryptTextSeparator
            // 
            this.EncryptDecryptTextSeparator.BackColor = System.Drawing.Color.Transparent;
            this.EncryptDecryptTextSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EncryptDecryptTextSeparator.BackgroundImage")));
            this.EncryptDecryptTextSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EncryptDecryptTextSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.Transition2.SetDecoration(this.EncryptDecryptTextSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.EncryptDecryptTextSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.EncryptDecryptTextSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.EncryptDecryptTextSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.EncryptDecryptTextSeparator.LineThickness = 5;
            this.EncryptDecryptTextSeparator.Location = new System.Drawing.Point(82, 252);
            this.EncryptDecryptTextSeparator.Name = "EncryptDecryptTextSeparator";
            this.EncryptDecryptTextSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.EncryptDecryptTextSeparator.Size = new System.Drawing.Size(10, 50);
            this.EncryptDecryptTextSeparator.TabIndex = 22;
            // 
            // btnEncryptDecryptText
            // 
            this.btnEncryptDecryptText.ActiveImage = global::Secure_Email_Application.Properties.Resources.EncryptAndDecrypt_Selected;
            this.btnEncryptDecryptText.AllowAnimations = true;
            this.btnEncryptDecryptText.AllowBuffering = false;
            this.btnEncryptDecryptText.AllowToggling = false;
            this.btnEncryptDecryptText.AllowZooming = true;
            this.btnEncryptDecryptText.AllowZoomingOnFocus = false;
            this.btnEncryptDecryptText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Transition2.SetDecoration(this.btnEncryptDecryptText, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnEncryptDecryptText, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnEncryptDecryptText.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEncryptDecryptText.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEncryptDecryptText.ErrorImage")));
            this.btnEncryptDecryptText.FadeWhenInactive = false;
            this.btnEncryptDecryptText.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnEncryptDecryptText.Image = global::Secure_Email_Application.Properties.Resources.EncryptAndDecrypt;
            this.btnEncryptDecryptText.ImageActive = global::Secure_Email_Application.Properties.Resources.EncryptAndDecrypt_Selected;
            this.btnEncryptDecryptText.ImageLocation = null;
            this.btnEncryptDecryptText.ImageMargin = 5;
            this.btnEncryptDecryptText.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEncryptDecryptText.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.btnEncryptDecryptText.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnEncryptDecryptText.InitialImage")));
            this.btnEncryptDecryptText.Location = new System.Drawing.Point(23, 258);
            this.btnEncryptDecryptText.Name = "btnEncryptDecryptText";
            this.btnEncryptDecryptText.Rotation = 0;
            this.btnEncryptDecryptText.ShowActiveImage = true;
            this.btnEncryptDecryptText.ShowCursorChanges = true;
            this.btnEncryptDecryptText.ShowImageBorders = true;
            this.btnEncryptDecryptText.ShowSizeMarkers = false;
            this.btnEncryptDecryptText.Size = new System.Drawing.Size(45, 45);
            this.btnEncryptDecryptText.TabIndex = 21;
            this.btnEncryptDecryptText.ToolTipText = "";
            this.btnEncryptDecryptText.WaitOnLoad = false;
            this.btnEncryptDecryptText.Zoom = 5;
            this.btnEncryptDecryptText.ZoomSpeed = 10;
            this.btnEncryptDecryptText.Click += new System.EventHandler(this.btnEncryptDecryptText_Click);
            // 
            // btnLock
            // 
            this.btnLock.AllowAnimations = true;
            this.btnLock.AllowMouseEffects = true;
            this.btnLock.AllowToggling = false;
            this.btnLock.AnimationSpeed = 200;
            this.btnLock.AutoGenerateColors = false;
            this.btnLock.AutoRoundBorders = false;
            this.btnLock.AutoSizeLeftIcon = true;
            this.btnLock.AutoSizeRightIcon = true;
            this.btnLock.BackColor = System.Drawing.Color.Transparent;
            this.btnLock.BackColor1 = System.Drawing.Color.White;
            this.btnLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLock.BackgroundImage")));
            this.btnLock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLock.ButtonText = "";
            this.btnLock.ButtonTextMarginLeft = 0;
            this.btnLock.ColorContrastOnClick = 45;
            this.btnLock.ColorContrastOnHover = 45;
            this.btnLock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLock.CustomizableEdges = borderEdges1;
            this.Transition2.SetDecoration(this.btnLock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnLock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnLock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnLock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLock.IconLeftPadding = new System.Windows.Forms.Padding(1);
            this.btnLock.IconMarginLeft = 11;
            this.btnLock.IconPadding = 1;
            this.btnLock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLock.IconSize = 25;
            this.btnLock.IdleBorderColor = System.Drawing.Color.White;
            this.btnLock.IdleBorderRadius = 48;
            this.btnLock.IdleBorderThickness = 1;
            this.btnLock.IdleFillColor = System.Drawing.Color.White;
            this.btnLock.IdleIconLeftImage = global::Secure_Email_Application.Properties.Resources.LockApp;
            this.btnLock.IdleIconRightImage = null;
            this.btnLock.IndicateFocus = false;
            this.btnLock.Location = new System.Drawing.Point(20, 675);
            this.btnLock.Name = "btnLock";
            this.btnLock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLock.OnDisabledState.BorderRadius = 48;
            this.btnLock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLock.OnDisabledState.BorderThickness = 1;
            this.btnLock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLock.OnDisabledState.IconLeftImage = null;
            this.btnLock.OnDisabledState.IconRightImage = null;
            this.btnLock.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnLock.onHoverState.BorderRadius = 48;
            this.btnLock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLock.onHoverState.BorderThickness = 1;
            this.btnLock.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnLock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLock.onHoverState.IconLeftImage = null;
            this.btnLock.onHoverState.IconRightImage = null;
            this.btnLock.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnLock.OnIdleState.BorderRadius = 48;
            this.btnLock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLock.OnIdleState.BorderThickness = 1;
            this.btnLock.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnLock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLock.OnIdleState.IconLeftImage = global::Secure_Email_Application.Properties.Resources.LockApp;
            this.btnLock.OnIdleState.IconRightImage = null;
            this.btnLock.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnLock.OnPressedState.BorderRadius = 48;
            this.btnLock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLock.OnPressedState.BorderThickness = 1;
            this.btnLock.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnLock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLock.OnPressedState.IconLeftImage = null;
            this.btnLock.OnPressedState.IconRightImage = null;
            this.btnLock.Size = new System.Drawing.Size(50, 50);
            this.btnLock.TabIndex = 18;
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLock.TextMarginLeft = 0;
            this.btnLock.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLock.UseDefaultRadiusAndThickness = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnSent
            // 
            this.btnSent.ActiveImage = global::Secure_Email_Application.Properties.Resources.Sent_Selected;
            this.btnSent.AllowAnimations = true;
            this.btnSent.AllowBuffering = false;
            this.btnSent.AllowToggling = false;
            this.btnSent.AllowZooming = true;
            this.btnSent.AllowZoomingOnFocus = false;
            this.btnSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Transition2.SetDecoration(this.btnSent, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnSent, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSent.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSent.ErrorImage")));
            this.btnSent.FadeWhenInactive = false;
            this.btnSent.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSent.Image = global::Secure_Email_Application.Properties.Resources.Sent;
            this.btnSent.ImageActive = global::Secure_Email_Application.Properties.Resources.Sent_Selected;
            this.btnSent.ImageLocation = null;
            this.btnSent.ImageMargin = 5;
            this.btnSent.ImageSize = new System.Drawing.Size(35, 32);
            this.btnSent.ImageZoomSize = new System.Drawing.Size(40, 37);
            this.btnSent.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSent.InitialImage")));
            this.btnSent.Location = new System.Drawing.Point(29, 183);
            this.btnSent.Name = "btnSent";
            this.btnSent.Rotation = 0;
            this.btnSent.ShowActiveImage = true;
            this.btnSent.ShowCursorChanges = true;
            this.btnSent.ShowImageBorders = true;
            this.btnSent.ShowSizeMarkers = false;
            this.btnSent.Size = new System.Drawing.Size(40, 37);
            this.btnSent.TabIndex = 15;
            this.btnSent.ToolTipText = "";
            this.btnSent.WaitOnLoad = false;
            this.btnSent.Zoom = 5;
            this.btnSent.ZoomSpeed = 10;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.ActiveImage = global::Secure_Email_Application.Properties.Resources.Inbox_Selected;
            this.btnInbox.AllowAnimations = true;
            this.btnInbox.AllowBuffering = false;
            this.btnInbox.AllowToggling = false;
            this.btnInbox.AllowZooming = true;
            this.btnInbox.AllowZoomingOnFocus = false;
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Transition2.SetDecoration(this.btnInbox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnInbox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnInbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInbox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnInbox.ErrorImage")));
            this.btnInbox.FadeWhenInactive = false;
            this.btnInbox.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnInbox.Image = global::Secure_Email_Application.Properties.Resources.Inbox;
            this.btnInbox.ImageActive = global::Secure_Email_Application.Properties.Resources.Inbox_Selected;
            this.btnInbox.ImageLocation = null;
            this.btnInbox.ImageMargin = 5;
            this.btnInbox.ImageSize = new System.Drawing.Size(33, 33);
            this.btnInbox.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.btnInbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnInbox.InitialImage")));
            this.btnInbox.Location = new System.Drawing.Point(29, 105);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Rotation = 0;
            this.btnInbox.ShowActiveImage = true;
            this.btnInbox.ShowCursorChanges = true;
            this.btnInbox.ShowImageBorders = true;
            this.btnInbox.ShowSizeMarkers = false;
            this.btnInbox.Size = new System.Drawing.Size(38, 38);
            this.btnInbox.TabIndex = 1;
            this.btnInbox.ToolTipText = "";
            this.btnInbox.WaitOnLoad = false;
            this.btnInbox.Zoom = 5;
            this.btnInbox.ZoomSpeed = 10;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // SentSeparator
            // 
            this.SentSeparator.BackColor = System.Drawing.Color.Transparent;
            this.SentSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SentSeparator.BackgroundImage")));
            this.SentSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SentSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.Transition2.SetDecoration(this.SentSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.SentSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SentSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.SentSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.SentSeparator.LineThickness = 5;
            this.SentSeparator.Location = new System.Drawing.Point(82, 176);
            this.SentSeparator.Name = "SentSeparator";
            this.SentSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.SentSeparator.Size = new System.Drawing.Size(10, 50);
            this.SentSeparator.TabIndex = 11;
            // 
            // InboxSeparator
            // 
            this.InboxSeparator.BackColor = System.Drawing.Color.Transparent;
            this.InboxSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InboxSeparator.BackgroundImage")));
            this.InboxSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InboxSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.Transition2.SetDecoration(this.InboxSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.InboxSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.InboxSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.InboxSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.InboxSeparator.LineThickness = 5;
            this.InboxSeparator.Location = new System.Drawing.Point(82, 97);
            this.InboxSeparator.Name = "InboxSeparator";
            this.InboxSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.InboxSeparator.Size = new System.Drawing.Size(10, 50);
            this.InboxSeparator.TabIndex = 10;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.Transition2.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.bunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(23, 650);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(45, 10);
            this.bunifuSeparator2.TabIndex = 9;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.Transition2.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 71);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(60, 10);
            this.bunifuSeparator1.TabIndex = 5;
            // 
            // EmailInfoPanel
            // 
            this.EmailInfoPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.EmailInfoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailInfoPanel.BackgroundImage")));
            this.EmailInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmailInfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.EmailInfoPanel.BorderRadius = 0;
            this.EmailInfoPanel.BorderThickness = 0;
            this.EmailInfoPanel.Controls.Add(this.EmailsPanel);
            this.EmailInfoPanel.Controls.Add(this.lblContent);
            this.EmailInfoPanel.Controls.Add(this.btnComposeNewEmail);
            this.EmailInfoPanel.Controls.Add(this.btnLoadFiles);
            this.EmailInfoPanel.Controls.Add(this.bunifuSeparator3);
            this.EmailInfoPanel.Controls.Add(this.txtSearch);
            this.Transition2.SetDecoration(this.EmailInfoPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.EmailInfoPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.EmailInfoPanel.Location = new System.Drawing.Point(89, 39);
            this.EmailInfoPanel.MaximumSize = new System.Drawing.Size(400, 750);
            this.EmailInfoPanel.Name = "EmailInfoPanel";
            this.EmailInfoPanel.ShowBorders = true;
            this.EmailInfoPanel.Size = new System.Drawing.Size(345, 750);
            this.EmailInfoPanel.TabIndex = 1;
            // 
            // EmailsPanel
            // 
            this.EmailsPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.EmailsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailsPanel.BackgroundImage")));
            this.EmailsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmailsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.EmailsPanel.BorderRadius = 0;
            this.EmailsPanel.BorderThickness = 0;
            this.Transition2.SetDecoration(this.EmailsPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.EmailsPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.EmailsPanel.Location = new System.Drawing.Point(6, 160);
            this.EmailsPanel.Name = "EmailsPanel";
            this.EmailsPanel.ShowBorders = true;
            this.EmailsPanel.Size = new System.Drawing.Size(335, 575);
            this.EmailsPanel.TabIndex = 0;
            // 
            // lblContent
            // 
            this.lblContent.AllowParentOverrides = false;
            this.lblContent.AutoEllipsis = false;
            this.lblContent.AutoSize = false;
            this.lblContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblContent.CursorType = System.Windows.Forms.Cursors.Default;
            this.Transition1.SetDecoration(this.lblContent, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition2.SetDecoration(this.lblContent, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.lblContent.Location = new System.Drawing.Point(80, 128);
            this.lblContent.Name = "lblContent";
            this.lblContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContent.Size = new System.Drawing.Size(185, 21);
            this.lblContent.TabIndex = 19;
            this.lblContent.Text = "Content";
            this.lblContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContent.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnComposeNewEmail
            // 
            this.btnComposeNewEmail.AllowAnimations = true;
            this.btnComposeNewEmail.AllowMouseEffects = true;
            this.btnComposeNewEmail.AllowToggling = false;
            this.btnComposeNewEmail.AnimationSpeed = 200;
            this.btnComposeNewEmail.AutoGenerateColors = false;
            this.btnComposeNewEmail.AutoRoundBorders = false;
            this.btnComposeNewEmail.AutoSizeLeftIcon = true;
            this.btnComposeNewEmail.AutoSizeRightIcon = true;
            this.btnComposeNewEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnComposeNewEmail.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnComposeNewEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComposeNewEmail.BackgroundImage")));
            this.btnComposeNewEmail.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnComposeNewEmail.ButtonText = "Compose";
            this.btnComposeNewEmail.ButtonTextMarginLeft = 0;
            this.btnComposeNewEmail.ColorContrastOnClick = 45;
            this.btnComposeNewEmail.ColorContrastOnHover = 45;
            this.btnComposeNewEmail.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnComposeNewEmail.CustomizableEdges = borderEdges2;
            this.Transition2.SetDecoration(this.btnComposeNewEmail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnComposeNewEmail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnComposeNewEmail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComposeNewEmail.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnComposeNewEmail.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnComposeNewEmail.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnComposeNewEmail.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnComposeNewEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnComposeNewEmail.ForeColor = System.Drawing.Color.White;
            this.btnComposeNewEmail.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComposeNewEmail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnComposeNewEmail.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnComposeNewEmail.IconMarginLeft = 11;
            this.btnComposeNewEmail.IconPadding = 7;
            this.btnComposeNewEmail.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComposeNewEmail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnComposeNewEmail.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnComposeNewEmail.IconSize = 25;
            this.btnComposeNewEmail.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnComposeNewEmail.IdleBorderRadius = 10;
            this.btnComposeNewEmail.IdleBorderThickness = 1;
            this.btnComposeNewEmail.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnComposeNewEmail.IdleIconLeftImage = global::Secure_Email_Application.Properties.Resources.Compose_Email_Button;
            this.btnComposeNewEmail.IdleIconRightImage = null;
            this.btnComposeNewEmail.IndicateFocus = false;
            this.btnComposeNewEmail.Location = new System.Drawing.Point(210, 85);
            this.btnComposeNewEmail.Name = "btnComposeNewEmail";
            this.btnComposeNewEmail.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnComposeNewEmail.OnDisabledState.BorderRadius = 10;
            this.btnComposeNewEmail.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnComposeNewEmail.OnDisabledState.BorderThickness = 1;
            this.btnComposeNewEmail.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnComposeNewEmail.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnComposeNewEmail.OnDisabledState.IconLeftImage = null;
            this.btnComposeNewEmail.OnDisabledState.IconRightImage = null;
            this.btnComposeNewEmail.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnComposeNewEmail.onHoverState.BorderRadius = 10;
            this.btnComposeNewEmail.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnComposeNewEmail.onHoverState.BorderThickness = 1;
            this.btnComposeNewEmail.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnComposeNewEmail.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnComposeNewEmail.onHoverState.IconLeftImage = null;
            this.btnComposeNewEmail.onHoverState.IconRightImage = null;
            this.btnComposeNewEmail.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnComposeNewEmail.OnIdleState.BorderRadius = 10;
            this.btnComposeNewEmail.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnComposeNewEmail.OnIdleState.BorderThickness = 1;
            this.btnComposeNewEmail.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnComposeNewEmail.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnComposeNewEmail.OnIdleState.IconLeftImage = global::Secure_Email_Application.Properties.Resources.Compose_Email_Button;
            this.btnComposeNewEmail.OnIdleState.IconRightImage = null;
            this.btnComposeNewEmail.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnComposeNewEmail.OnPressedState.BorderRadius = 10;
            this.btnComposeNewEmail.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnComposeNewEmail.OnPressedState.BorderThickness = 1;
            this.btnComposeNewEmail.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnComposeNewEmail.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnComposeNewEmail.OnPressedState.IconLeftImage = null;
            this.btnComposeNewEmail.OnPressedState.IconRightImage = null;
            this.btnComposeNewEmail.Size = new System.Drawing.Size(125, 35);
            this.btnComposeNewEmail.TabIndex = 16;
            this.btnComposeNewEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComposeNewEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComposeNewEmail.TextMarginLeft = 0;
            this.btnComposeNewEmail.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnComposeNewEmail.UseDefaultRadiusAndThickness = true;
            this.btnComposeNewEmail.Click += new System.EventHandler(this.btnComposeNewEmail_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.AllowAnimations = true;
            this.btnLoadFiles.AllowMouseEffects = true;
            this.btnLoadFiles.AllowToggling = false;
            this.btnLoadFiles.AnimationSpeed = 200;
            this.btnLoadFiles.AutoGenerateColors = false;
            this.btnLoadFiles.AutoRoundBorders = false;
            this.btnLoadFiles.AutoSizeLeftIcon = true;
            this.btnLoadFiles.AutoSizeRightIcon = true;
            this.btnLoadFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadFiles.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnLoadFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadFiles.BackgroundImage")));
            this.btnLoadFiles.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLoadFiles.ButtonText = "Load file";
            this.btnLoadFiles.ButtonTextMarginLeft = 0;
            this.btnLoadFiles.ColorContrastOnClick = 45;
            this.btnLoadFiles.ColorContrastOnHover = 45;
            this.btnLoadFiles.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnLoadFiles.CustomizableEdges = borderEdges3;
            this.Transition2.SetDecoration(this.btnLoadFiles, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.btnLoadFiles, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnLoadFiles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadFiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoadFiles.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoadFiles.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoadFiles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnLoadFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFiles.ForeColor = System.Drawing.Color.White;
            this.btnLoadFiles.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadFiles.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoadFiles.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLoadFiles.IconMarginLeft = 11;
            this.btnLoadFiles.IconPadding = 6;
            this.btnLoadFiles.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadFiles.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLoadFiles.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLoadFiles.IconSize = 25;
            this.btnLoadFiles.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnLoadFiles.IdleBorderRadius = 10;
            this.btnLoadFiles.IdleBorderThickness = 1;
            this.btnLoadFiles.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnLoadFiles.IdleIconLeftImage = global::Secure_Email_Application.Properties.Resources.LoadFiles;
            this.btnLoadFiles.IdleIconRightImage = null;
            this.btnLoadFiles.IndicateFocus = false;
            this.btnLoadFiles.Location = new System.Drawing.Point(10, 85);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLoadFiles.OnDisabledState.BorderRadius = 10;
            this.btnLoadFiles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLoadFiles.OnDisabledState.BorderThickness = 1;
            this.btnLoadFiles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoadFiles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoadFiles.OnDisabledState.IconLeftImage = null;
            this.btnLoadFiles.OnDisabledState.IconRightImage = null;
            this.btnLoadFiles.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoadFiles.onHoverState.BorderRadius = 10;
            this.btnLoadFiles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLoadFiles.onHoverState.BorderThickness = 1;
            this.btnLoadFiles.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoadFiles.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLoadFiles.onHoverState.IconLeftImage = null;
            this.btnLoadFiles.onHoverState.IconRightImage = null;
            this.btnLoadFiles.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnLoadFiles.OnIdleState.BorderRadius = 10;
            this.btnLoadFiles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLoadFiles.OnIdleState.BorderThickness = 1;
            this.btnLoadFiles.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnLoadFiles.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLoadFiles.OnIdleState.IconLeftImage = global::Secure_Email_Application.Properties.Resources.LoadFiles;
            this.btnLoadFiles.OnIdleState.IconRightImage = null;
            this.btnLoadFiles.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoadFiles.OnPressedState.BorderRadius = 10;
            this.btnLoadFiles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnLoadFiles.OnPressedState.BorderThickness = 1;
            this.btnLoadFiles.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoadFiles.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLoadFiles.OnPressedState.IconLeftImage = null;
            this.btnLoadFiles.OnPressedState.IconRightImage = null;
            this.btnLoadFiles.Size = new System.Drawing.Size(125, 35);
            this.btnLoadFiles.TabIndex = 15;
            this.btnLoadFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadFiles.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoadFiles.TextMarginLeft = 0;
            this.btnLoadFiles.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLoadFiles.UseDefaultRadiusAndThickness = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.Transition2.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.bunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 70);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(345, 10);
            this.bunifuSeparator3.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition2.SetDecoration(this.txtSearch, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this.txtSearch, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 5;
            this.txtSearch.IconRight = global::Secure_Email_Application.Properties.Resources.Search;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(10, 20);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.txtSearch.PlaceholderText = "Enter text";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(325, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Enter text";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.OnIconRightClick += new System.EventHandler(this.txtSearch_OnIconRightClick);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // bgwSendUserLogEmail
            // 
            this.bgwSendUserLogEmail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSendUserLogEmail_DoWork);
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation2;
            this.Transition1.Interval = 1;
            this.Transition1.MaxAnimationTime = 1000;
            // 
            // Transition2
            // 
            this.Transition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.Transition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition2.DefaultAnimation = animation1;
            this.Transition2.Interval = 1;
            this.Transition2.MaxAnimationTime = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 790);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.EmailInfoPanel);
            this.Controls.Add(this.TopPanel);
            this.Transition2.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Email";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.TopPanel.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.EmailInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator SentSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator InboxSeparator;
        private Bunifu.UI.WinForms.BunifuPanel EmailInfoPanel;
        private Bunifu.UI.WinForms.BunifuImageButton btnInbox;
        private Bunifu.UI.WinForms.BunifuImageButton btnSent;
        private Bunifu.UI.WinForms.BunifuPanel TopPanel;
        private Bunifu.UI.WinForms.BunifuPanel ContentPanel;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.UI.WinForms.BunifuLabel lblContent;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnComposeNewEmail;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnLoadFiles;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuPanel EmailsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnLock;
        private Bunifu.UI.WinForms.BunifuImageButton btnEncryptDecryptText;
        private Bunifu.UI.WinForms.BunifuSeparator EncryptDecryptTextSeparator;
        private System.Windows.Forms.PictureBox pbIcon;
        private Bunifu.UI.WinForms.BunifuImageButton btnSettings;
        private System.ComponentModel.BackgroundWorker bgwSendUserLogEmail;
        private Bunifu.UI.WinForms.BunifuTransition Transition1;
        private Bunifu.UI.WinForms.BunifuTransition Transition2;
    }
}

