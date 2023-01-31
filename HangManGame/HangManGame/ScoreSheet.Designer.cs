namespace HangManGame
{
    partial class ScoreSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreSheet));
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mainMenuButton
            // 
            resources.ApplyResources(this.mainMenuButton, "mainMenuButton");
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AcceptsTab = true;
            resources.ApplyResources(this.scoreLabel, "scoreLabel");
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.TabStop = false;
            // 
            // ScoreSheet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label1);
            this.Name = "ScoreSheet";
            this.Load += new System.EventHandler(this.ScoreSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.RichTextBox scoreLabel;
    }
}