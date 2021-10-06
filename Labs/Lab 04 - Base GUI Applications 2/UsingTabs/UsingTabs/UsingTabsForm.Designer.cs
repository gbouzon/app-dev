
namespace UsingTabs
{
    partial class UsingTabsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.displayLabel = new System.Windows.Forms.Label();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.helloRadioButton = new System.Windows.Forms.RadioButton();
            this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
            this.messageLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 135);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.greenRadioButton);
            this.tabPage1.Controls.Add(this.redRadioButton);
            this.tabPage1.Controls.Add(this.blackRadioButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Colour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.size20RadioButton);
            this.tabPage2.Controls.Add(this.size16RadioButton);
            this.tabPage2.Controls.Add(this.size12RadioButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Size";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.goodbyeRadioButton);
            this.tabPage3.Controls.Add(this.helloRadioButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(282, 106);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Message";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.messageLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(282, 106);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(6, 17);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(63, 21);
            this.blackRadioButton.TabIndex = 1;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(6, 44);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(55, 21);
            this.redRadioButton.TabIndex = 2;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(6, 71);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(69, 21);
            this.greenRadioButton.TabIndex = 3;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(28, 175);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(255, 76);
            this.displayLabel.TabIndex = 4;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayLabel.Text = "Hello!"; //default text
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Location = new System.Drawing.Point(6, 18);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(80, 21);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 point";
            this.size12RadioButton.UseVisualStyleBackColor = true;
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Location = new System.Drawing.Point(6, 45);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(80, 21);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.TabStop = true;
            this.size16RadioButton.Text = "16 point";
            this.size16RadioButton.UseVisualStyleBackColor = true;
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Location = new System.Drawing.Point(6, 72);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(80, 21);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.TabStop = true;
            this.size20RadioButton.Text = "20 point";
            this.size20RadioButton.UseVisualStyleBackColor = true;
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // helloRadioButton
            // 
            this.helloRadioButton.AutoSize = true;
            this.helloRadioButton.Location = new System.Drawing.Point(6, 19);
            this.helloRadioButton.Name = "helloRadioButton";
            this.helloRadioButton.Size = new System.Drawing.Size(64, 21);
            this.helloRadioButton.TabIndex = 0;
            this.helloRadioButton.TabStop = true;
            this.helloRadioButton.Text = "Hello!";
            this.helloRadioButton.UseVisualStyleBackColor = true;
            this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
            // 
            // goodbyeRadioButton
            // 
            this.goodbyeRadioButton.AutoSize = true;
            this.goodbyeRadioButton.Location = new System.Drawing.Point(6, 46);
            this.goodbyeRadioButton.Name = "goodbyeRadioButton";
            this.goodbyeRadioButton.Size = new System.Drawing.Size(90, 21);
            this.goodbyeRadioButton.TabIndex = 1;
            this.goodbyeRadioButton.TabStop = true;
            this.goodbyeRadioButton.Text = "Goodbye!";
            this.goodbyeRadioButton.UseVisualStyleBackColor = true;
            this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
            // 
            // messageLabel
            // 
            this.messageLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.messageLabel.Location = new System.Drawing.Point(12, 32);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(247, 39);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Tabs are used to organize controls and conserve screen space.";
            // 
            // UsingTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 260);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "UsingTabsForm";
            this.Text = "Using Tabs";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.RadioButton size20RadioButton;
        private System.Windows.Forms.RadioButton size16RadioButton;
        private System.Windows.Forms.RadioButton size12RadioButton;
        private System.Windows.Forms.RadioButton goodbyeRadioButton;
        private System.Windows.Forms.RadioButton helloRadioButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

