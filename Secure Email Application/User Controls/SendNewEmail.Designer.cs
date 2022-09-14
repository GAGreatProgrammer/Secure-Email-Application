
namespace Secure_Email_Application.User_Controls
{
    partial class SendNewEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendNewEmail));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnSend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuSeparator4 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnAddAttachment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtBody = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtSubject = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bgwSendEmail = new System.ComponentModel.BackgroundWorker();
            this.AttachmentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator5 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.Snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AllowAnimations = true;
            this.btnSend.AllowMouseEffects = true;
            this.btnSend.AllowToggling = false;
            this.btnSend.AnimationSpeed = 200;
            this.btnSend.AutoGenerateColors = false;
            this.btnSend.AutoRoundBorders = false;
            this.btnSend.AutoSizeLeftIcon = true;
            this.btnSend.AutoSizeRightIcon = true;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSend.ButtonText = "Send";
            this.btnSend.ButtonTextMarginLeft = 0;
            this.btnSend.ColorContrastOnClick = 45;
            this.btnSend.ColorContrastOnHover = 45;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSend.CustomizableEdges = borderEdges1;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSend.IconMarginLeft = 11;
            this.btnSend.IconPadding = 10;
            this.btnSend.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSend.IconSize = 25;
            this.btnSend.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.IdleBorderRadius = 30;
            this.btnSend.IdleBorderThickness = 1;
            this.btnSend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.IdleIconLeftImage = null;
            this.btnSend.IdleIconRightImage = null;
            this.btnSend.IndicateFocus = false;
            this.btnSend.Location = new System.Drawing.Point(765, 695);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.OnDisabledState.BorderRadius = 30;
            this.btnSend.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSend.OnDisabledState.BorderThickness = 1;
            this.btnSend.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.OnDisabledState.IconLeftImage = null;
            this.btnSend.OnDisabledState.IconRightImage = null;
            this.btnSend.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSend.onHoverState.BorderRadius = 30;
            this.btnSend.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSend.onHoverState.BorderThickness = 1;
            this.btnSend.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSend.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSend.onHoverState.IconLeftImage = null;
            this.btnSend.onHoverState.IconRightImage = null;
            this.btnSend.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.OnIdleState.BorderRadius = 30;
            this.btnSend.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSend.OnIdleState.BorderThickness = 1;
            this.btnSend.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSend.OnIdleState.IconLeftImage = null;
            this.btnSend.OnIdleState.IconRightImage = null;
            this.btnSend.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.OnPressedState.BorderRadius = 30;
            this.btnSend.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSend.OnPressedState.BorderThickness = 1;
            this.btnSend.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSend.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSend.OnPressedState.IconLeftImage = null;
            this.btnSend.OnPressedState.IconRightImage = null;
            this.btnSend.Size = new System.Drawing.Size(150, 40);
            this.btnSend.TabIndex = 19;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.TextMarginLeft = 0;
            this.btnSend.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSend.UseDefaultRadiusAndThickness = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator4.BackgroundImage")));
            this.bunifuSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator4.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuSeparator4.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator4.LineThickness = 3;
            this.bunifuSeparator4.Location = new System.Drawing.Point(25, 677);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator4.Size = new System.Drawing.Size(890, 14);
            this.bunifuSeparator4.TabIndex = 18;
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.AllowAnimations = true;
            this.btnAddAttachment.AllowMouseEffects = true;
            this.btnAddAttachment.AllowToggling = false;
            this.btnAddAttachment.AnimationSpeed = 200;
            this.btnAddAttachment.AutoGenerateColors = false;
            this.btnAddAttachment.AutoRoundBorders = false;
            this.btnAddAttachment.AutoSizeLeftIcon = true;
            this.btnAddAttachment.AutoSizeRightIcon = true;
            this.btnAddAttachment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAttachment.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAttachment.BackgroundImage")));
            this.btnAddAttachment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddAttachment.ButtonText = "Add attachment";
            this.btnAddAttachment.ButtonTextMarginLeft = 0;
            this.btnAddAttachment.ColorContrastOnClick = 45;
            this.btnAddAttachment.ColorContrastOnHover = 45;
            this.btnAddAttachment.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddAttachment.CustomizableEdges = borderEdges2;
            this.btnAddAttachment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAttachment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddAttachment.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddAttachment.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddAttachment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAddAttachment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttachment.ForeColor = System.Drawing.Color.White;
            this.btnAddAttachment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAttachment.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddAttachment.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddAttachment.IconMarginLeft = 11;
            this.btnAddAttachment.IconPadding = 10;
            this.btnAddAttachment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAttachment.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddAttachment.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddAttachment.IconSize = 25;
            this.btnAddAttachment.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.IdleBorderRadius = 30;
            this.btnAddAttachment.IdleBorderThickness = 1;
            this.btnAddAttachment.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.IdleIconLeftImage = null;
            this.btnAddAttachment.IdleIconRightImage = null;
            this.btnAddAttachment.IndicateFocus = false;
            this.btnAddAttachment.Location = new System.Drawing.Point(25, 695);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddAttachment.OnDisabledState.BorderRadius = 30;
            this.btnAddAttachment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddAttachment.OnDisabledState.BorderThickness = 1;
            this.btnAddAttachment.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddAttachment.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddAttachment.OnDisabledState.IconLeftImage = null;
            this.btnAddAttachment.OnDisabledState.IconRightImage = null;
            this.btnAddAttachment.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnAddAttachment.onHoverState.BorderRadius = 30;
            this.btnAddAttachment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddAttachment.onHoverState.BorderThickness = 1;
            this.btnAddAttachment.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnAddAttachment.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddAttachment.onHoverState.IconLeftImage = null;
            this.btnAddAttachment.onHoverState.IconRightImage = null;
            this.btnAddAttachment.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.OnIdleState.BorderRadius = 30;
            this.btnAddAttachment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddAttachment.OnIdleState.BorderThickness = 1;
            this.btnAddAttachment.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddAttachment.OnIdleState.IconLeftImage = null;
            this.btnAddAttachment.OnIdleState.IconRightImage = null;
            this.btnAddAttachment.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.OnPressedState.BorderRadius = 30;
            this.btnAddAttachment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddAttachment.OnPressedState.BorderThickness = 1;
            this.btnAddAttachment.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btnAddAttachment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddAttachment.OnPressedState.IconLeftImage = null;
            this.btnAddAttachment.OnPressedState.IconRightImage = null;
            this.btnAddAttachment.Size = new System.Drawing.Size(230, 40);
            this.btnAddAttachment.TabIndex = 17;
            this.btnAddAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAttachment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAttachment.TextMarginLeft = 0;
            this.btnAddAttachment.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddAttachment.UseDefaultRadiusAndThickness = true;
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click_1);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(25, 574);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(870, 14);
            this.bunifuSeparator3.TabIndex = 16;
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
            this.txtBody.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtBody.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBody.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBody.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBody.BorderRadius = 30;
            this.txtBody.BorderThickness = 1;
            this.txtBody.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
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
            this.txtBody.Location = new System.Drawing.Point(25, 203);
            this.txtBody.MaxLength = 32767;
            this.txtBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBody.Modified = false;
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBody.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBody.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBody.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
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
            this.txtBody.Size = new System.Drawing.Size(890, 365);
            this.txtBody.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBody.TabIndex = 15;
            this.txtBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBody.TextMarginBottom = 0;
            this.txtBody.TextMarginLeft = 3;
            this.txtBody.TextMarginTop = 1;
            this.txtBody.TextPlaceholder = "Body";
            this.txtBody.UseSystemPasswordChar = false;
            this.txtBody.WordWrap = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(25, 183);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(890, 14);
            this.bunifuSeparator2.TabIndex = 14;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(25, 117);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(890, 14);
            this.bunifuSeparator1.TabIndex = 13;
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
            this.txtSubject.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtSubject.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSubject.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSubject.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSubject.BorderRadius = 30;
            this.txtSubject.BorderThickness = 1;
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
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
            this.txtSubject.Location = new System.Drawing.Point(25, 137);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSubject.Modified = false;
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubject.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSubject.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSubject.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
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
            this.txtSubject.Size = new System.Drawing.Size(890, 40);
            this.txtSubject.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSubject.TabIndex = 12;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubject.TextMarginBottom = 0;
            this.txtSubject.TextMarginLeft = 3;
            this.txtSubject.TextMarginTop = 1;
            this.txtSubject.TextPlaceholder = "Subject";
            this.txtSubject.UseSystemPasswordChar = false;
            this.txtSubject.WordWrap = true;
            // 
            // txtTo
            // 
            this.txtTo.AcceptsReturn = false;
            this.txtTo.AcceptsTab = false;
            this.txtTo.AnimationSpeed = 200;
            this.txtTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTo.AutoSizeHeight = true;
            this.txtTo.BackColor = System.Drawing.Color.White;
            this.txtTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTo.BackgroundImage")));
            this.txtTo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTo.BorderRadius = 30;
            this.txtTo.BorderThickness = 1;
            this.txtTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTo.DefaultText = "";
            this.txtTo.FillColor = System.Drawing.Color.White;
            this.txtTo.ForeColor = System.Drawing.Color.Black;
            this.txtTo.HideSelection = true;
            this.txtTo.IconLeft = null;
            this.txtTo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.IconPadding = 10;
            this.txtTo.IconRight = null;
            this.txtTo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.Lines = new string[0];
            this.txtTo.Location = new System.Drawing.Point(25, 71);
            this.txtTo.MaxLength = 32767;
            this.txtTo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTo.Modified = false;
            this.txtTo.Multiline = false;
            this.txtTo.Name = "txtTo";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTo.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTo.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTo.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Black;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTo.OnIdleState = stateProperties12;
            this.txtTo.Padding = new System.Windows.Forms.Padding(3);
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.txtTo.PlaceholderText = "To";
            this.txtTo.ReadOnly = false;
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionLength = 0;
            this.txtTo.SelectionStart = 0;
            this.txtTo.ShortcutsEnabled = true;
            this.txtTo.Size = new System.Drawing.Size(890, 40);
            this.txtTo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTo.TabIndex = 11;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTo.TextMarginBottom = 0;
            this.txtTo.TextMarginLeft = 3;
            this.txtTo.TextMarginTop = 1;
            this.txtTo.TextPlaceholder = "To";
            this.txtTo.UseSystemPasswordChar = false;
            this.txtTo.WordWrap = true;
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
            this.btnBack.TabIndex = 20;
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
            this.bunifuLabel1.Location = new System.Drawing.Point(73, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(197, 30);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Compose new email";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bgwSendEmail
            // 
            this.bgwSendEmail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSendEmail_DoWork);
            this.bgwSendEmail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSendEmail_RunWorkerCompleted);
            // 
            // AttachmentPanel
            // 
            this.AttachmentPanel.AutoScroll = true;
            this.AttachmentPanel.Location = new System.Drawing.Point(25, 594);
            this.AttachmentPanel.Name = "AttachmentPanel";
            this.AttachmentPanel.Size = new System.Drawing.Size(890, 80);
            this.AttachmentPanel.TabIndex = 20;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator5.BackgroundImage")));
            this.bunifuSeparator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator5.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuSeparator5.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator5.LineThickness = 3;
            this.bunifuSeparator5.Location = new System.Drawing.Point(25, 51);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator5.Size = new System.Drawing.Size(890, 14);
            this.bunifuSeparator5.TabIndex = 23;
            // 
            // Snackbar
            // 
            this.Snackbar.AllowDragging = false;
            this.Snackbar.AllowMultipleViews = true;
            this.Snackbar.ClickToClose = true;
            this.Snackbar.DoubleClickToClose = true;
            this.Snackbar.DurationAfterIdle = 3000;
            this.Snackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.ErrorOptions.ActionBorderRadius = 1;
            this.Snackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Snackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Snackbar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Snackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Snackbar.ErrorOptions.IconLeftMargin = 12;
            this.Snackbar.FadeCloseIcon = false;
            this.Snackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Snackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.InformationOptions.ActionBorderRadius = 1;
            this.Snackbar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Snackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Snackbar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Snackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Snackbar.InformationOptions.IconLeftMargin = 12;
            this.Snackbar.Margin = 10;
            this.Snackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.Snackbar.MaximumViews = 7;
            this.Snackbar.MessageRightMargin = 15;
            this.Snackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.Snackbar.ShowBorders = false;
            this.Snackbar.ShowCloseIcon = true;
            this.Snackbar.ShowIcon = true;
            this.Snackbar.ShowShadows = true;
            this.Snackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.SuccessOptions.ActionBorderRadius = 1;
            this.Snackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.Black;
            this.Snackbar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Snackbar.SuccessOptions.IconLeftMargin = 12;
            this.Snackbar.ViewsMargin = 7;
            this.Snackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.WarningOptions.ActionBorderRadius = 1;
            this.Snackbar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.WarningOptions.CloseIconColor = System.Drawing.Color.Black;
            this.Snackbar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Snackbar.WarningOptions.IconLeftMargin = 12;
            this.Snackbar.ZoomCloseIcon = true;
            // 
            // SendNewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.AttachmentPanel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.btnAddAttachment);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Name = "SendNewEmail";
            this.Size = new System.Drawing.Size(935, 750);
            this.Load += new System.EventHandler(this.SendNewEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSend;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAddAttachment;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuTextBox txtBody;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox txtSubject;
        private Bunifu.UI.WinForms.BunifuTextBox txtTo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.ComponentModel.BackgroundWorker bgwSendEmail;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private System.Windows.Forms.FlowLayoutPanel AttachmentPanel;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator5;
        private Bunifu.UI.WinForms.BunifuSnackbar Snackbar;
    }
}
