namespace WMK
{
    partial class MainWindow
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTime = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonDocument = new System.Windows.Forms.RadioButton();
            this.radioButtonRecommendation = new System.Windows.Forms.RadioButton();
            this.radioButtonAnalysis = new System.Windows.Forms.RadioButton();
            this.radioButtonEmail = new System.Windows.Forms.RadioButton();
            this.radioButtonCourt = new System.Windows.Forms.RadioButton();
            this.radioButtonCall = new System.Windows.Forms.RadioButton();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTime);
            this.tabControl1.Controls.Add(this.tabPageClient);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(315, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTime
            // 
            this.tabPageTime.BackColor = System.Drawing.Color.White;
            this.tabPageTime.Controls.Add(this.buttonSave);
            this.tabPageTime.Controls.Add(this.button1);
            this.tabPageTime.Controls.Add(this.radioButtonOther);
            this.tabPageTime.Controls.Add(this.radioButtonDocument);
            this.tabPageTime.Controls.Add(this.radioButtonRecommendation);
            this.tabPageTime.Controls.Add(this.radioButtonAnalysis);
            this.tabPageTime.Controls.Add(this.radioButtonEmail);
            this.tabPageTime.Controls.Add(this.radioButtonCourt);
            this.tabPageTime.Controls.Add(this.radioButtonCall);
            this.tabPageTime.Controls.Add(this.textBoxComment);
            this.tabPageTime.Controls.Add(this.buttonAddClient);
            this.tabPageTime.Controls.Add(this.buttonPause);
            this.tabPageTime.Controls.Add(this.buttonPlay);
            this.tabPageTime.Controls.Add(this.labelTime);
            this.tabPageTime.Controls.Add(this.comboBoxClient);
            this.tabPageTime.Location = new System.Drawing.Point(4, 24);
            this.tabPageTime.Name = "tabPageTime";
            this.tabPageTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTime.Size = new System.Drawing.Size(307, 229);
            this.tabPageTime.TabIndex = 0;
            this.tabPageTime.Text = "Czas";
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::WMK.Properties.Resources.icon_save;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Location = new System.Drawing.Point(251, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 50);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOther.BackgroundImage = global::WMK.Properties.Resources.icon_other;
            this.radioButtonOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonOther.Location = new System.Drawing.Point(90, 83);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(36, 36);
            this.radioButtonOther.TabIndex = 24;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.Visible = false;
            this.radioButtonOther.CheckedChanged += new System.EventHandler(this.radioButtonOther_CheckedChanged);
            // 
            // radioButtonDocument
            // 
            this.radioButtonDocument.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDocument.BackgroundImage = global::WMK.Properties.Resources.icon_document;
            this.radioButtonDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonDocument.Location = new System.Drawing.Point(132, 41);
            this.radioButtonDocument.Name = "radioButtonDocument";
            this.radioButtonDocument.Size = new System.Drawing.Size(36, 36);
            this.radioButtonDocument.TabIndex = 23;
            this.radioButtonDocument.TabStop = true;
            this.radioButtonDocument.UseVisualStyleBackColor = true;
            this.radioButtonDocument.Visible = false;
            this.radioButtonDocument.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // radioButtonRecommendation
            // 
            this.radioButtonRecommendation.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRecommendation.BackgroundImage = global::WMK.Properties.Resources.icon_recommendation;
            this.radioButtonRecommendation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonRecommendation.Location = new System.Drawing.Point(48, 83);
            this.radioButtonRecommendation.Name = "radioButtonRecommendation";
            this.radioButtonRecommendation.Size = new System.Drawing.Size(36, 36);
            this.radioButtonRecommendation.TabIndex = 22;
            this.radioButtonRecommendation.TabStop = true;
            this.radioButtonRecommendation.UseVisualStyleBackColor = true;
            this.radioButtonRecommendation.Visible = false;
            this.radioButtonRecommendation.CheckedChanged += new System.EventHandler(this.radioButtonRecommendation_CheckedChanged);
            // 
            // radioButtonAnalysis
            // 
            this.radioButtonAnalysis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAnalysis.BackgroundImage = global::WMK.Properties.Resources.icon_investigation;
            this.radioButtonAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonAnalysis.Location = new System.Drawing.Point(6, 83);
            this.radioButtonAnalysis.Name = "radioButtonAnalysis";
            this.radioButtonAnalysis.Size = new System.Drawing.Size(36, 36);
            this.radioButtonAnalysis.TabIndex = 21;
            this.radioButtonAnalysis.TabStop = true;
            this.radioButtonAnalysis.UseVisualStyleBackColor = true;
            this.radioButtonAnalysis.Visible = false;
            this.radioButtonAnalysis.CheckedChanged += new System.EventHandler(this.radioButtonAnalysis_CheckedChanged);
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEmail.BackgroundImage = global::WMK.Properties.Resources.icon_email;
            this.radioButtonEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonEmail.Location = new System.Drawing.Point(90, 41);
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Size = new System.Drawing.Size(36, 36);
            this.radioButtonEmail.TabIndex = 20;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            this.radioButtonEmail.Visible = false;
            this.radioButtonEmail.CheckedChanged += new System.EventHandler(this.radioButtonEmail_CheckedChanged);
            // 
            // radioButtonCourt
            // 
            this.radioButtonCourt.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCourt.BackgroundImage = global::WMK.Properties.Resources.icon_court;
            this.radioButtonCourt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonCourt.Location = new System.Drawing.Point(48, 41);
            this.radioButtonCourt.Name = "radioButtonCourt";
            this.radioButtonCourt.Size = new System.Drawing.Size(36, 36);
            this.radioButtonCourt.TabIndex = 19;
            this.radioButtonCourt.TabStop = true;
            this.radioButtonCourt.UseVisualStyleBackColor = true;
            this.radioButtonCourt.Visible = false;
            this.radioButtonCourt.CheckedChanged += new System.EventHandler(this.radioButtonCourt_CheckedChanged);
            // 
            // radioButtonCall
            // 
            this.radioButtonCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCall.BackgroundImage = global::WMK.Properties.Resources.icon_call;
            this.radioButtonCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonCall.Location = new System.Drawing.Point(6, 41);
            this.radioButtonCall.Name = "radioButtonCall";
            this.radioButtonCall.Size = new System.Drawing.Size(36, 36);
            this.radioButtonCall.TabIndex = 18;
            this.radioButtonCall.TabStop = true;
            this.radioButtonCall.UseVisualStyleBackColor = true;
            this.radioButtonCall.Visible = false;
            this.radioButtonCall.CheckedChanged += new System.EventHandler(this.radioButtonCall_CheckedChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Enabled = false;
            this.textBoxComment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(6, 125);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(162, 33);
            this.textBoxComment.TabIndex = 10;
            this.textBoxComment.Visible = false;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackgroundImage = global::WMK.Properties.Resources.icon_add_user;
            this.buttonAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddClient.Location = new System.Drawing.Point(155, 5);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(32, 32);
            this.buttonAddClient.TabIndex = 9;
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = global::WMK.Properties.Resources.icon_pause;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(251, 60);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(50, 50);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::WMK.Properties.Resources.icon_play;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Location = new System.Drawing.Point(251, 6);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(50, 50);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(109, 170);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(102, 25);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "                  ";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(6, 6);
            this.comboBoxClient.MaxDropDownItems = 20;
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(143, 29);
            this.comboBoxClient.Sorted = true;
            this.comboBoxClient.TabIndex = 2;
            this.comboBoxClient.Text = "Wybierz";
            // 
            // tabPageClient
            // 
            this.tabPageClient.BackColor = System.Drawing.Color.White;
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(307, 229);
            this.tabPageClient.TabIndex = 1;
            this.tabPageClient.Text = "Klient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WMK.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(167, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(344, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "WMK";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTime.ResumeLayout(false);
            this.tabPageTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageTime;
        private TabPage tabPageClient;
        private PictureBox pictureBox1;
        private Label labelTime;
        private Button buttonPlay;
        private Button buttonPause;
        private System.Windows.Forms.Timer timerTime;
        private Button buttonAddClient;
        private RadioButton radioButtonCall;
        private RadioButton radioButtonCourt;
        private RadioButton radioButtonOther;
        private RadioButton radioButtonDocument;
        private RadioButton radioButtonRecommendation;
        private RadioButton radioButtonAnalysis;
        private RadioButton radioButtonEmail;
        private Button button1;
        public ComboBox comboBoxClient;
        public TextBox textBoxComment;
        private Button buttonSave;
    }
}