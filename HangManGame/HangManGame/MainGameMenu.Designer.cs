namespace HangManGame
{
    partial class MainGameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameMenu));
            this.newButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.csRadio = new System.Windows.Forms.RadioButton();
            this.bgRadio = new System.Windows.Forms.RadioButton();
            this.sRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newButton
            // 
            resources.ApplyResources(this.newButton, "newButton");
            this.newButton.Name = "newButton";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // csRadio
            // 
            resources.ApplyResources(this.csRadio, "csRadio");
            this.csRadio.Name = "csRadio";
            this.csRadio.UseVisualStyleBackColor = true;
            this.csRadio.CheckedChanged += new System.EventHandler(this.radioGroup1_Clicked);
            // 
            // bgRadio
            // 
            resources.ApplyResources(this.bgRadio, "bgRadio");
            this.bgRadio.Name = "bgRadio";
            this.bgRadio.UseVisualStyleBackColor = true;
            this.bgRadio.CheckedChanged += new System.EventHandler(this.radioGroup1_Clicked);
            // 
            // sRadio
            // 
            resources.ApplyResources(this.sRadio, "sRadio");
            this.sRadio.Name = "sRadio";
            this.sRadio.UseVisualStyleBackColor = true;
            this.sRadio.CheckedChanged += new System.EventHandler(this.radioGroup1_Clicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // helpButton
            // 
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // titlePictureBox
            // 
            resources.ApplyResources(this.titlePictureBox, "titlePictureBox");
            this.titlePictureBox.Image = global::HangManGame.Properties.Resources.title;
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.csRadio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bgRadio);
            this.groupBox1.Controls.Add(this.sRadio);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Name = "label5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainGameMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newButton);
            this.Name = "MainGameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton csRadio;
        public System.Windows.Forms.RadioButton bgRadio;
        public System.Windows.Forms.RadioButton sRadio;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}