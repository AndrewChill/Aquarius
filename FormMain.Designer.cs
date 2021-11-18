
namespace Aquarius
{
    partial class FormMain
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTwitchChannel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBackgroundColor = new System.Windows.Forms.TextBox();
            this.buttonBackgroundColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFontColor = new System.Windows.Forms.TextBox();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBorderColor = new System.Windows.Forms.TextBox();
            this.buttonBorderColor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTwitchToken = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTwitchClientID = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxFontFamily = new System.Windows.Forms.ComboBox();
            this.checkBoxRefreshOnLoad = new System.Windows.Forms.CheckBox();
            this.checkBoxRefreshOnTimer = new System.Windows.Forms.CheckBox();
            this.numericUpDownRefreshTimerDuration = new System.Windows.Forms.NumericUpDown();
            this.linkLabelOpenPanelPreview = new System.Windows.Forms.LinkLabel();
            this.numericUpDownDisplayDuration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTransitionDuration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPortNumber = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshTimerDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransitionDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(309, 637);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(130, 32);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh Panel";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApply.Enabled = false;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(161, 637);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(130, 32);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Save Changes";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Channel Name";
            // 
            // textBoxTwitchChannel
            // 
            this.textBoxTwitchChannel.BackColor = System.Drawing.Color.Black;
            this.textBoxTwitchChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTwitchChannel.ForeColor = System.Drawing.Color.White;
            this.textBoxTwitchChannel.Location = new System.Drawing.Point(6, 49);
            this.textBoxTwitchChannel.Name = "textBoxTwitchChannel";
            this.textBoxTwitchChannel.Size = new System.Drawing.Size(416, 26);
            this.textBoxTwitchChannel.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxTwitchChannel, "The name of the Twitch channel to pull predictions from.");
            this.textBoxTwitchChannel.TextChanged += new System.EventHandler(this.controlTwitch_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transition Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(302, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Height";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.BackColor = System.Drawing.Color.Black;
            this.numericUpDownWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWidth.ForeColor = System.Drawing.Color.White;
            this.numericUpDownWidth.Location = new System.Drawing.Point(154, 50);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownWidth.TabIndex = 3;
            this.toolTip.SetToolTip(this.numericUpDownWidth, "The total width of the panel, including the border. This should match the size of" +
        " the Browser control in Obs.");
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.BackColor = System.Drawing.Color.Black;
            this.numericUpDownHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHeight.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHeight.Location = new System.Drawing.Point(302, 50);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownHeight.TabIndex = 3;
            this.toolTip.SetToolTip(this.numericUpDownHeight, "The total height of the panel, including the border. This should match the size o" +
        "f the Browser control in Obs.");
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Background Color";
            // 
            // textBoxBackgroundColor
            // 
            this.textBoxBackgroundColor.BackColor = System.Drawing.Color.Black;
            this.textBoxBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBackgroundColor.ForeColor = System.Drawing.Color.White;
            this.textBoxBackgroundColor.Location = new System.Drawing.Point(6, 49);
            this.textBoxBackgroundColor.Name = "textBoxBackgroundColor";
            this.textBoxBackgroundColor.Size = new System.Drawing.Size(93, 26);
            this.textBoxBackgroundColor.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxBackgroundColor, "The background color of the panel. Can be \'transparent\'.");
            this.textBoxBackgroundColor.TextChanged += new System.EventHandler(this.textBoxBackgroundColor_TextChanged);
            // 
            // buttonBackgroundColor
            // 
            this.buttonBackgroundColor.BackColor = System.Drawing.Color.White;
            this.buttonBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackgroundColor.Location = new System.Drawing.Point(100, 49);
            this.buttonBackgroundColor.Name = "buttonBackgroundColor";
            this.buttonBackgroundColor.Size = new System.Drawing.Size(26, 26);
            this.buttonBackgroundColor.TabIndex = 5;
            this.buttonBackgroundColor.UseVisualStyleBackColor = false;
            this.buttonBackgroundColor.Click += new System.EventHandler(this.buttonBackgroundColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Font Color";
            // 
            // textBoxFontColor
            // 
            this.textBoxFontColor.BackColor = System.Drawing.Color.Black;
            this.textBoxFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFontColor.ForeColor = System.Drawing.Color.White;
            this.textBoxFontColor.Location = new System.Drawing.Point(6, 105);
            this.textBoxFontColor.Name = "textBoxFontColor";
            this.textBoxFontColor.Size = new System.Drawing.Size(93, 26);
            this.textBoxFontColor.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxFontColor, "The color to use for text in the panel.");
            this.textBoxFontColor.TextChanged += new System.EventHandler(this.textBoxFontColor_TextChanged);
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.BackColor = System.Drawing.Color.White;
            this.buttonFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFontColor.Location = new System.Drawing.Point(100, 105);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(26, 26);
            this.buttonFontColor.TabIndex = 5;
            this.buttonFontColor.UseVisualStyleBackColor = false;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.BackColor = System.Drawing.Color.Black;
            this.numericUpDownFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFontSize.ForeColor = System.Drawing.Color.White;
            this.numericUpDownFontSize.Location = new System.Drawing.Point(154, 106);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownFontSize.TabIndex = 7;
            this.toolTip.SetToolTip(this.numericUpDownFontSize, "The font size to use for text in the panel.");
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(154, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Font Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(302, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Font Family";
            // 
            // textBoxBorderColor
            // 
            this.textBoxBorderColor.BackColor = System.Drawing.Color.Black;
            this.textBoxBorderColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorderColor.ForeColor = System.Drawing.Color.White;
            this.textBoxBorderColor.Location = new System.Drawing.Point(6, 161);
            this.textBoxBorderColor.Name = "textBoxBorderColor";
            this.textBoxBorderColor.Size = new System.Drawing.Size(93, 26);
            this.textBoxBorderColor.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxBorderColor, "The color of the border around the panel.");
            this.textBoxBorderColor.TextChanged += new System.EventHandler(this.textBoxBorderColor_TextChanged);
            // 
            // buttonBorderColor
            // 
            this.buttonBorderColor.BackColor = System.Drawing.Color.White;
            this.buttonBorderColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBorderColor.Location = new System.Drawing.Point(100, 161);
            this.buttonBorderColor.Name = "buttonBorderColor";
            this.buttonBorderColor.Size = new System.Drawing.Size(26, 26);
            this.buttonBorderColor.TabIndex = 5;
            this.buttonBorderColor.UseVisualStyleBackColor = false;
            this.buttonBorderColor.Click += new System.EventHandler(this.buttonBorderColor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(154, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Border Width";
            // 
            // numericUpDownBorderWidth
            // 
            this.numericUpDownBorderWidth.BackColor = System.Drawing.Color.Black;
            this.numericUpDownBorderWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBorderWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBorderWidth.ForeColor = System.Drawing.Color.White;
            this.numericUpDownBorderWidth.Location = new System.Drawing.Point(154, 161);
            this.numericUpDownBorderWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownBorderWidth.Name = "numericUpDownBorderWidth";
            this.numericUpDownBorderWidth.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownBorderWidth.TabIndex = 7;
            this.toolTip.SetToolTip(this.numericUpDownBorderWidth, "The width of the border around the panel. Included in the Width value.");
            this.numericUpDownBorderWidth.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Access Token";
            // 
            // textBoxTwitchToken
            // 
            this.textBoxTwitchToken.BackColor = System.Drawing.Color.Black;
            this.textBoxTwitchToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTwitchToken.ForeColor = System.Drawing.Color.White;
            this.textBoxTwitchToken.Location = new System.Drawing.Point(6, 105);
            this.textBoxTwitchToken.Name = "textBoxTwitchToken";
            this.textBoxTwitchToken.PasswordChar = '●';
            this.textBoxTwitchToken.Size = new System.Drawing.Size(416, 26);
            this.textBoxTwitchToken.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxTwitchToken, "The Twitch Access Token that has been granted permission to view predictions. You" +
        " can generate a custom scope token at twitchtokengenerator.com");
            this.textBoxTwitchToken.TextChanged += new System.EventHandler(this.controlTwitch_Changed);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Client ID";
            // 
            // textBoxTwitchClientID
            // 
            this.textBoxTwitchClientID.BackColor = System.Drawing.Color.Black;
            this.textBoxTwitchClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTwitchClientID.ForeColor = System.Drawing.Color.White;
            this.textBoxTwitchClientID.Location = new System.Drawing.Point(6, 161);
            this.textBoxTwitchClientID.Name = "textBoxTwitchClientID";
            this.textBoxTwitchClientID.PasswordChar = '●';
            this.textBoxTwitchClientID.Size = new System.Drawing.Size(416, 26);
            this.textBoxTwitchClientID.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxTwitchClientID, "The Twitch Client ID associated with the above Access Token. You can get this alo" +
        "ng with the token at twitchtokengenerator.com");
            this.textBoxTwitchClientID.TextChanged += new System.EventHandler(this.controlTwitch_Changed);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 20;
            // 
            // comboBoxFontFamily
            // 
            this.comboBoxFontFamily.BackColor = System.Drawing.Color.Black;
            this.comboBoxFontFamily.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFontFamily.ForeColor = System.Drawing.Color.White;
            this.comboBoxFontFamily.FormattingEnabled = true;
            this.comboBoxFontFamily.Location = new System.Drawing.Point(302, 105);
            this.comboBoxFontFamily.Name = "comboBoxFontFamily";
            this.comboBoxFontFamily.Size = new System.Drawing.Size(120, 28);
            this.comboBoxFontFamily.TabIndex = 8;
            this.toolTip.SetToolTip(this.comboBoxFontFamily, "The font family to use for text in the panel.");
            this.comboBoxFontFamily.SelectedIndexChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // checkBoxRefreshOnLoad
            // 
            this.checkBoxRefreshOnLoad.AutoSize = true;
            this.checkBoxRefreshOnLoad.Location = new System.Drawing.Point(6, 85);
            this.checkBoxRefreshOnLoad.Name = "checkBoxRefreshOnLoad";
            this.checkBoxRefreshOnLoad.Size = new System.Drawing.Size(331, 24);
            this.checkBoxRefreshOnLoad.TabIndex = 8;
            this.checkBoxRefreshOnLoad.Text = "Refresh panel immediately on browser load";
            this.toolTip.SetToolTip(this.checkBoxRefreshOnLoad, "Whether or not to retrieve and send new info to the panel as soon as the browser " +
        "loads the page.");
            this.checkBoxRefreshOnLoad.UseVisualStyleBackColor = true;
            this.checkBoxRefreshOnLoad.CheckedChanged += new System.EventHandler(this.controlTwitch_Changed);
            // 
            // checkBoxRefreshOnTimer
            // 
            this.checkBoxRefreshOnTimer.AutoSize = true;
            this.checkBoxRefreshOnTimer.Location = new System.Drawing.Point(6, 118);
            this.checkBoxRefreshOnTimer.Name = "checkBoxRefreshOnTimer";
            this.checkBoxRefreshOnTimer.Size = new System.Drawing.Size(277, 24);
            this.checkBoxRefreshOnTimer.TabIndex = 8;
            this.checkBoxRefreshOnTimer.Text = "Refresh panel every X milliseconds:";
            this.toolTip.SetToolTip(this.checkBoxRefreshOnTimer, "Whether or not to retrieve and send new info to the panel at the following timer " +
        "interval.\r\n");
            this.checkBoxRefreshOnTimer.UseVisualStyleBackColor = true;
            this.checkBoxRefreshOnTimer.CheckedChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // numericUpDownRefreshTimerDuration
            // 
            this.numericUpDownRefreshTimerDuration.BackColor = System.Drawing.Color.Black;
            this.numericUpDownRefreshTimerDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownRefreshTimerDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRefreshTimerDuration.ForeColor = System.Drawing.Color.White;
            this.numericUpDownRefreshTimerDuration.Location = new System.Drawing.Point(302, 116);
            this.numericUpDownRefreshTimerDuration.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownRefreshTimerDuration.Name = "numericUpDownRefreshTimerDuration";
            this.numericUpDownRefreshTimerDuration.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRefreshTimerDuration.TabIndex = 7;
            this.numericUpDownRefreshTimerDuration.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownRefreshTimerDuration, "How often, in milliseconds, to retrieve and send new info to the panel if this op" +
        "tion is enabled. Note that refreshing too frequently could result in Twitch thro" +
        "ttling API access, I don\'t really know.");
            this.numericUpDownRefreshTimerDuration.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // linkLabelOpenPanelPreview
            // 
            this.linkLabelOpenPanelPreview.AutoSize = true;
            this.linkLabelOpenPanelPreview.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkLabelOpenPanelPreview.Location = new System.Drawing.Point(316, 0);
            this.linkLabelOpenPanelPreview.Name = "linkLabelOpenPanelPreview";
            this.linkLabelOpenPanelPreview.Size = new System.Drawing.Size(106, 20);
            this.linkLabelOpenPanelPreview.TabIndex = 9;
            this.linkLabelOpenPanelPreview.TabStop = true;
            this.linkLabelOpenPanelPreview.Text = "Open Preview";
            this.toolTip.SetToolTip(this.linkLabelOpenPanelPreview, "Opens the panel in your default web browser. Note that it may be rendered slightl" +
        "y differently in Obs\' Browser.");
            this.linkLabelOpenPanelPreview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenPanelPreview_LinkClicked);
            // 
            // numericUpDownDisplayDuration
            // 
            this.numericUpDownDisplayDuration.BackColor = System.Drawing.Color.Black;
            this.numericUpDownDisplayDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDisplayDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDisplayDuration.ForeColor = System.Drawing.Color.White;
            this.numericUpDownDisplayDuration.Location = new System.Drawing.Point(6, 217);
            this.numericUpDownDisplayDuration.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownDisplayDuration.Name = "numericUpDownDisplayDuration";
            this.numericUpDownDisplayDuration.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDisplayDuration.TabIndex = 7;
            this.numericUpDownDisplayDuration.ThousandsSeparator = true;
            this.numericUpDownDisplayDuration.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // numericUpDownTransitionDuration
            // 
            this.numericUpDownTransitionDuration.BackColor = System.Drawing.Color.Black;
            this.numericUpDownTransitionDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTransitionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTransitionDuration.ForeColor = System.Drawing.Color.White;
            this.numericUpDownTransitionDuration.Location = new System.Drawing.Point(154, 217);
            this.numericUpDownTransitionDuration.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownTransitionDuration.Name = "numericUpDownTransitionDuration";
            this.numericUpDownTransitionDuration.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownTransitionDuration.TabIndex = 7;
            this.numericUpDownTransitionDuration.ThousandsSeparator = true;
            this.numericUpDownTransitionDuration.ValueChanged += new System.EventHandler(this.controlBasic_Changed);
            // 
            // numericUpDownPortNumber
            // 
            this.numericUpDownPortNumber.BackColor = System.Drawing.Color.Black;
            this.numericUpDownPortNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPortNumber.ForeColor = System.Drawing.Color.White;
            this.numericUpDownPortNumber.Location = new System.Drawing.Point(6, 49);
            this.numericUpDownPortNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownPortNumber.Name = "numericUpDownPortNumber";
            this.numericUpDownPortNumber.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownPortNumber.TabIndex = 7;
            this.numericUpDownPortNumber.ValueChanged += new System.EventHandler(this.controlOverlay_Changed);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Border Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxTwitchChannel);
            this.groupBox1.Controls.Add(this.textBoxTwitchToken);
            this.groupBox1.Controls.Add(this.textBoxTwitchClientID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch Integration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabelOpenPanelPreview);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxFontFamily);
            this.groupBox2.Controls.Add(this.numericUpDownTransitionDuration);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownDisplayDuration);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDownBorderWidth);
            this.groupBox2.Controls.Add(this.numericUpDownWidth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numericUpDownHeight);
            this.groupBox2.Controls.Add(this.numericUpDownFontSize);
            this.groupBox2.Controls.Add(this.textBoxBackgroundColor);
            this.groupBox2.Controls.Add(this.buttonBorderColor);
            this.groupBox2.Controls.Add(this.textBoxFontColor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonBackgroundColor);
            this.groupBox2.Controls.Add(this.buttonFontColor);
            this.groupBox2.Controls.Add(this.textBoxBorderColor);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 253);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel Display";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxRefreshOnTimer);
            this.groupBox3.Controls.Add(this.checkBoxRefreshOnLoad);
            this.groupBox3.Controls.Add(this.numericUpDownPortNumber);
            this.groupBox3.Controls.Add(this.numericUpDownRefreshTimerDuration);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 153);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aquarius Settings";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(451, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonRefresh);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Aquarius";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshTimerDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransitionDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTwitchChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBackgroundColor;
        private System.Windows.Forms.Button buttonBackgroundColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFontColor;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBorderColor;
        private System.Windows.Forms.Button buttonBorderColor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTwitchToken;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxTwitchClientID;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox comboBoxFontFamily;
        private System.Windows.Forms.NumericUpDown numericUpDownDisplayDuration;
        private System.Windows.Forms.NumericUpDown numericUpDownTransitionDuration;
        private System.Windows.Forms.NumericUpDown numericUpDownPortNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRefreshOnLoad;
        private System.Windows.Forms.CheckBox checkBoxRefreshOnTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownRefreshTimerDuration;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.LinkLabel linkLabelOpenPanelPreview;
    }
}

