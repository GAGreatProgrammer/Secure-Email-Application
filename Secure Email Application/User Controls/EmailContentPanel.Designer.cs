
namespace Secure_Email_Application.User_Controls
{
    partial class EmailContentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailContentPanel));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.txtBody = new Bunifu.UI.WinForms.BunifuTextBox();
            this.AttachmentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSubject = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnIndicator = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblFrom = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblDateTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDecrypt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bgwDecrypt = new System.ComponentModel.BackgroundWorker();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bgwGetData = new System.ComponentModel.BackgroundWorker();
            this.btnDownloadEncryptedFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnDownloadDecryptedFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bgwDownloadEncryptedFiles = new System.ComponentModel.BackgroundWorker();
            this.bgwDownloadDecryptedFiles = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtBody
            // 
            this.txtBody.AcceptsReturn = false;
            this.txtBody.AcceptsTab = false;
            this.txtBody.AnimationSpeed = 200;
            this.txtBody.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBody.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBody.AutoSizeHeight = true;
            this.txtBody.BackColor = System.Drawing.Color.Transparent;
            this.txtBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBody.BackgroundImage")));
            this.txtBody.BorderColorActive = System.Drawing.Color.White;
            this.txtBody.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBody.BorderColorHover = System.Drawing.Color.White;
            this.txtBody.BorderColorIdle = System.Drawing.Color.White;
            this.txtBody.BorderRadius = 1;
            this.txtBody.BorderThickness = 0;
            this.txtBody.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.DefaultFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.DefaultText = "";
            this.txtBody.FillColor = System.Drawing.Color.White;
            this.txtBody.ForeColor = System.Drawing.Color.Black;
            this.txtBody.HideSelection = true;
            this.txtBody.IconLeft = null;
            this.txtBody.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.IconPadding = 10;
            this.txtBody.IconRight = null;
            this.txtBody.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.Lines = new string[0];
            this.txtBody.Location = new System.Drawing.Point(25, 162);
            this.txtBody.MaxLength = 32767;
            this.txtBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBody.Modified = false;
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBody.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBody.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBody.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBody.OnIdleState = stateProperties4;
            this.txtBody.Padding = new System.Windows.Forms.Padding(3);
            this.txtBody.PasswordChar = '\0';
            this.txtBody.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.txtBody.PlaceholderText = "Body";
            this.txtBody.ReadOnly = false;
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.SelectedText = "";
            this.txtBody.SelectionLength = 0;
            this.txtBody.SelectionStart = 0;
            this.txtBody.ShortcutsEnabled = true;
            this.txtBody.Size = new System.Drawing.Size(881, 420);
            this.txtBody.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBody.TabIndex = 16;
            this.txtBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBody.TextMarginBottom = 0;
            this.txtBody.TextMarginLeft = 3;
            this.txtBody.TextMarginTop = 1;
            this.txtBody.TextPlaceholder = "Body";
            this.txtBody.UseSystemPasswordChar = false;
            this.txtBody.WordWrap = true;
            // 
            // AttachmentPanel
            // 
            this.AttachmentPanel.AutoScroll = true;
            this.AttachmentPanel.Location = new System.Drawing.Point(25, 595);
            this.AttachmentPanel.Name = "AttachmentPanel";
            this.AttachmentPanel.Size = new System.Drawing.Size(880, 80);
            this.AttachmentPanel.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.AcceptsReturn = false;
            this.txtSubject.AcceptsTab = false;
            this.txtSubject.AnimationSpeed = 200;
            this.txtSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSubject.AutoSizeHeight = true;
            this.txtSubject.BackColor = System.Drawing.Color.Transparent;
            this.txtSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSubject.BackgroundImage")));
            this.txtSubject.BorderColorActive = System.Drawing.Color.White;
            this.txtSubject.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSubject.BorderColorHover = System.Drawing.Color.White;
            this.txtSubject.BorderColorIdle = System.Drawing.Color.White;
            this.txtSubject.BorderRadius = 1;
            this.txtSubject.BorderThickness = 0;
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.DefaultFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.DefaultText = "";
            this.txtSubject.FillColor = System.Drawing.Color.White;
            this.txtSubject.ForeColor = System.Drawing.Color.Black;
            this.txtSubject.HideSelection = true;
            this.txtSubject.IconLeft = null;
            this.txtSubject.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.IconPadding = 10;
            this.txtSubject.IconRight = null;
            this.txtSubject.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(25, 107);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSubject.Modified = false;
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            stateProperties5.BorderColor = System.Drawing.Color.White;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubject.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSubject.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.White;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubject.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubject.OnIdleState = stateProperties8;
            this.txtSubject.Padding = new System.Windows.Forms.Padding(3);
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.txtSubject.PlaceholderText = "Subject";
            this.txtSubject.ReadOnly = false;
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(881, 42);
            this.txtSubject.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSubject.TabIndex = 18;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubject.TextMarginBottom = 0;
            this.txtSubject.TextMarginLeft = 3;
            this.txtSubject.TextMarginTop = 1;
            this.txtSubject.TextPlaceholder = "Subject";
            this.txtSubject.UseSystemPasswordChar = false;
            this.txtSubject.WordWrap = true;
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
            this.btnIndicator.IdleBorderColor = System.Drawing.Color.White;
            this.btnIndicator.IdleBorderRadius = 10;
            this.btnIndicator.IdleBorderThickness = 1;
            this.btnIndicator.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnIndicator.IdleIconLeftImage = null;
            this.btnIndicator.IdleIconRightImage = null;
            this.btnIndicator.IndicateFocus = false;
            this.btnIndicator.Location = new System.Drawing.Point(15, 58);
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
            this.btnIndicator.OnIdleState.BorderColor = System.Drawing.Color.White;
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
            this.btnIndicator.TabIndex = 19;
            this.btnIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIndicator.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIndicator.TextMarginLeft = 0;
            this.btnIndicator.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIndicator.UseDefaultRadiusAndThickness = true;
            // 
            // lblFrom
            // 
            this.lblFrom.AllowParentOverrides = false;
            this.lblFrom.AutoEllipsis = false;
            this.lblFrom.AutoSize = false;
            this.lblFrom.BackColor = System.Drawing.Color.White;
            this.lblFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFrom.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(55, 58);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFrom.Size = new System.Drawing.Size(430, 25);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "Data";
            this.lblFrom.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFrom.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 95);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(880, 10);
            this.bunifuSeparator1.TabIndex = 22;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AllowParentOverrides = false;
            this.lblDateTime.AutoEllipsis = false;
            this.lblDateTime.AutoSize = false;
            this.lblDateTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.lblDateTime.Location = new System.Drawing.Point(725, 62);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateTime.Size = new System.Drawing.Size(180, 21);
            this.lblDateTime.TabIndex = 37;
            this.lblDateTime.Text = "Data";
            this.lblDateTime.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblDateTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDecrypt.CustomizableEdges = borderEdges2;
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
            this.btnDecrypt.Location = new System.Drawing.Point(25, 695);
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
            this.btnDecrypt.TabIndex = 39;
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDecrypt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecrypt.TextMarginLeft = 0;
            this.btnDecrypt.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDecrypt.UseDefaultRadiusAndThickness = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
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
            this.bunifuSeparator3.TabIndex = 41;
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
            this.btnBack.TabIndex = 42;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 5;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.bunifuLabel1.Size = new System.Drawing.Size(138, 30);
            this.bunifuLabel1.TabIndex = 43;
            this.bunifuLabel1.Text = "Read an Email";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bgwDecrypt
            // 
            this.bgwDecrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDecrypt_DoWork);
            this.bgwDecrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDecrypt_RunWorkerCompleted);
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
            this.bunifuSeparator2.Location = new System.Drawing.Point(25, 583);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(880, 10);
            this.bunifuSeparator2.TabIndex = 44;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator4.BackgroundImage")));
            this.bunifuSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator4.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.bunifuSeparator4.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(26, 150);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator4.Size = new System.Drawing.Size(880, 10);
            this.bunifuSeparator4.TabIndex = 45;
            // 
            // bgwGetData
            // 
            this.bgwGetData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetData_DoWork);
            this.bgwGetData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetData_RunWorkerCompleted);
            // 
            // btnDownloadEncryptedFiles
            // 
            this.btnDownloadEncryptedFiles.AllowAnimations = true;
            this.btnDownloadEncryptedFiles.AllowMouseEffects = true;
            this.btnDownloadEncryptedFiles.AllowToggling = false;
            this.btnDownloadEncryptedFiles.AnimationSpeed = 200;
            this.btnDownloadEncryptedFiles.AutoGenerateColors = false;
            this.btnDownloadEncryptedFiles.AutoRoundBorders = false;
            this.btnDownloadEncryptedFiles.AutoSizeLeftIcon = true;
            this.btnDownloadEncryptedFiles.AutoSizeRightIcon = true;
            this.btnDownloadEncryptedFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadEncryptedFiles.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownloadEncryptedFiles.BackgroundImage")));
            this.btnDownloadEncryptedFiles.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadEncryptedFiles.ButtonText = "Download encrypted files";
            this.btnDownloadEncryptedFiles.ButtonTextMarginLeft = 0;
            this.btnDownloadEncryptedFiles.ColorContrastOnClick = 45;
            this.btnDownloadEncryptedFiles.ColorContrastOnHover = 45;
            this.btnDownloadEncryptedFiles.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnDownloadEncryptedFiles.CustomizableEdges = borderEdges3;
            this.btnDownloadEncryptedFiles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDownloadEncryptedFiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDownloadEncryptedFiles.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDownloadEncryptedFiles.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDownloadEncryptedFiles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnDownloadEncryptedFiles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadEncryptedFiles.ForeColor = System.Drawing.Color.White;
            this.btnDownloadEncryptedFiles.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadEncryptedFiles.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadEncryptedFiles.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDownloadEncryptedFiles.IconMarginLeft = 11;
            this.btnDownloadEncryptedFiles.IconPadding = 10;
            this.btnDownloadEncryptedFiles.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadEncryptedFiles.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadEncryptedFiles.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDownloadEncryptedFiles.IconSize = 25;
            this.btnDownloadEncryptedFiles.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.IdleBorderRadius = 30;
            this.btnDownloadEncryptedFiles.IdleBorderThickness = 1;
            this.btnDownloadEncryptedFiles.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.IdleIconLeftImage = null;
            this.btnDownloadEncryptedFiles.IdleIconRightImage = null;
            this.btnDownloadEncryptedFiles.IndicateFocus = false;
            this.btnDownloadEncryptedFiles.Location = new System.Drawing.Point(185, 695);
            this.btnDownloadEncryptedFiles.Name = "btnDownloadEncryptedFiles";
            this.btnDownloadEncryptedFiles.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDownloadEncryptedFiles.OnDisabledState.BorderRadius = 30;
            this.btnDownloadEncryptedFiles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadEncryptedFiles.OnDisabledState.BorderThickness = 1;
            this.btnDownloadEncryptedFiles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDownloadEncryptedFiles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDownloadEncryptedFiles.OnDisabledState.IconLeftImage = null;
            this.btnDownloadEncryptedFiles.OnDisabledState.IconRightImage = null;
            this.btnDownloadEncryptedFiles.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDownloadEncryptedFiles.onHoverState.BorderRadius = 30;
            this.btnDownloadEncryptedFiles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadEncryptedFiles.onHoverState.BorderThickness = 1;
            this.btnDownloadEncryptedFiles.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDownloadEncryptedFiles.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadEncryptedFiles.onHoverState.IconLeftImage = null;
            this.btnDownloadEncryptedFiles.onHoverState.IconRightImage = null;
            this.btnDownloadEncryptedFiles.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.OnIdleState.BorderRadius = 30;
            this.btnDownloadEncryptedFiles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadEncryptedFiles.OnIdleState.BorderThickness = 1;
            this.btnDownloadEncryptedFiles.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadEncryptedFiles.OnIdleState.IconLeftImage = null;
            this.btnDownloadEncryptedFiles.OnIdleState.IconRightImage = null;
            this.btnDownloadEncryptedFiles.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.OnPressedState.BorderRadius = 30;
            this.btnDownloadEncryptedFiles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadEncryptedFiles.OnPressedState.BorderThickness = 1;
            this.btnDownloadEncryptedFiles.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadEncryptedFiles.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadEncryptedFiles.OnPressedState.IconLeftImage = null;
            this.btnDownloadEncryptedFiles.OnPressedState.IconRightImage = null;
            this.btnDownloadEncryptedFiles.Size = new System.Drawing.Size(325, 40);
            this.btnDownloadEncryptedFiles.TabIndex = 46;
            this.btnDownloadEncryptedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownloadEncryptedFiles.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDownloadEncryptedFiles.TextMarginLeft = 0;
            this.btnDownloadEncryptedFiles.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDownloadEncryptedFiles.UseDefaultRadiusAndThickness = true;
            this.btnDownloadEncryptedFiles.Click += new System.EventHandler(this.btnDownloadEncryptedFiles_Click);
            // 
            // btnDownloadDecryptedFiles
            // 
            this.btnDownloadDecryptedFiles.AllowAnimations = true;
            this.btnDownloadDecryptedFiles.AllowMouseEffects = true;
            this.btnDownloadDecryptedFiles.AllowToggling = false;
            this.btnDownloadDecryptedFiles.AnimationSpeed = 200;
            this.btnDownloadDecryptedFiles.AutoGenerateColors = false;
            this.btnDownloadDecryptedFiles.AutoRoundBorders = false;
            this.btnDownloadDecryptedFiles.AutoSizeLeftIcon = true;
            this.btnDownloadDecryptedFiles.AutoSizeRightIcon = true;
            this.btnDownloadDecryptedFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadDecryptedFiles.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownloadDecryptedFiles.BackgroundImage")));
            this.btnDownloadDecryptedFiles.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadDecryptedFiles.ButtonText = "Download decrypted files";
            this.btnDownloadDecryptedFiles.ButtonTextMarginLeft = 0;
            this.btnDownloadDecryptedFiles.ColorContrastOnClick = 45;
            this.btnDownloadDecryptedFiles.ColorContrastOnHover = 45;
            this.btnDownloadDecryptedFiles.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnDownloadDecryptedFiles.CustomizableEdges = borderEdges4;
            this.btnDownloadDecryptedFiles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDownloadDecryptedFiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDownloadDecryptedFiles.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDownloadDecryptedFiles.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDownloadDecryptedFiles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnDownloadDecryptedFiles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadDecryptedFiles.ForeColor = System.Drawing.Color.White;
            this.btnDownloadDecryptedFiles.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadDecryptedFiles.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadDecryptedFiles.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDownloadDecryptedFiles.IconMarginLeft = 11;
            this.btnDownloadDecryptedFiles.IconPadding = 10;
            this.btnDownloadDecryptedFiles.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadDecryptedFiles.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadDecryptedFiles.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDownloadDecryptedFiles.IconSize = 25;
            this.btnDownloadDecryptedFiles.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.IdleBorderRadius = 30;
            this.btnDownloadDecryptedFiles.IdleBorderThickness = 1;
            this.btnDownloadDecryptedFiles.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.IdleIconLeftImage = null;
            this.btnDownloadDecryptedFiles.IdleIconRightImage = null;
            this.btnDownloadDecryptedFiles.IndicateFocus = false;
            this.btnDownloadDecryptedFiles.Location = new System.Drawing.Point(521, 694);
            this.btnDownloadDecryptedFiles.Name = "btnDownloadDecryptedFiles";
            this.btnDownloadDecryptedFiles.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDownloadDecryptedFiles.OnDisabledState.BorderRadius = 30;
            this.btnDownloadDecryptedFiles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadDecryptedFiles.OnDisabledState.BorderThickness = 1;
            this.btnDownloadDecryptedFiles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDownloadDecryptedFiles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDownloadDecryptedFiles.OnDisabledState.IconLeftImage = null;
            this.btnDownloadDecryptedFiles.OnDisabledState.IconRightImage = null;
            this.btnDownloadDecryptedFiles.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDownloadDecryptedFiles.onHoverState.BorderRadius = 30;
            this.btnDownloadDecryptedFiles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadDecryptedFiles.onHoverState.BorderThickness = 1;
            this.btnDownloadDecryptedFiles.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDownloadDecryptedFiles.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadDecryptedFiles.onHoverState.IconLeftImage = null;
            this.btnDownloadDecryptedFiles.onHoverState.IconRightImage = null;
            this.btnDownloadDecryptedFiles.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.OnIdleState.BorderRadius = 30;
            this.btnDownloadDecryptedFiles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadDecryptedFiles.OnIdleState.BorderThickness = 1;
            this.btnDownloadDecryptedFiles.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadDecryptedFiles.OnIdleState.IconLeftImage = null;
            this.btnDownloadDecryptedFiles.OnIdleState.IconRightImage = null;
            this.btnDownloadDecryptedFiles.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.OnPressedState.BorderRadius = 30;
            this.btnDownloadDecryptedFiles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDownloadDecryptedFiles.OnPressedState.BorderThickness = 1;
            this.btnDownloadDecryptedFiles.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnDownloadDecryptedFiles.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadDecryptedFiles.OnPressedState.IconLeftImage = null;
            this.btnDownloadDecryptedFiles.OnPressedState.IconRightImage = null;
            this.btnDownloadDecryptedFiles.Size = new System.Drawing.Size(325, 40);
            this.btnDownloadDecryptedFiles.TabIndex = 47;
            this.btnDownloadDecryptedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownloadDecryptedFiles.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDownloadDecryptedFiles.TextMarginLeft = 0;
            this.btnDownloadDecryptedFiles.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDownloadDecryptedFiles.UseDefaultRadiusAndThickness = true;
            this.btnDownloadDecryptedFiles.Click += new System.EventHandler(this.btnDownloadDecryptedFiles_Click);
            // 
            // bgwDownloadEncryptedFiles
            // 
            this.bgwDownloadEncryptedFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDownloadEncryptedFiles_DoWork);
            this.bgwDownloadEncryptedFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDownloadEncryptedFiles_RunWorkerCompleted);
            // 
            // bgwDownloadDecryptedFiles
            // 
            this.bgwDownloadDecryptedFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDownloadDecryptedFiles_DoWork);
            this.bgwDownloadDecryptedFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDownloadDecryptedFiles_RunWorkerCompleted);
            // 
            // EmailContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDownloadDecryptedFiles);
            this.Controls.Add(this.btnDownloadEncryptedFiles);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnIndicator);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.AttachmentPanel);
            this.Controls.Add(this.txtBody);
            this.Name = "EmailContentPanel";
            this.Size = new System.Drawing.Size(935, 750);
            this.Load += new System.EventHandler(this.EmailContentPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txtBody;
        private System.Windows.Forms.FlowLayoutPanel AttachmentPanel;
        private Bunifu.UI.WinForms.BunifuTextBox txtSubject;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnIndicator;
        private Bunifu.UI.WinForms.BunifuLabel lblFrom;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lblDateTime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDecrypt;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.ComponentModel.BackgroundWorker bgwDecrypt;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator4;
        private System.ComponentModel.BackgroundWorker bgwGetData;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDownloadEncryptedFiles;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDownloadDecryptedFiles;
        private System.ComponentModel.BackgroundWorker bgwDownloadEncryptedFiles;
        private System.ComponentModel.BackgroundWorker bgwDownloadDecryptedFiles;
    }
}
