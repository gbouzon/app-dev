
namespace HugeInteger
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.input2TextBox = new System.Windows.Forms.TextBox();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.isEqualToCheckBox = new System.Windows.Forms.CheckBox();
            this.isNotEqualToCheckBox = new System.Windows.Forms.CheckBox();
            this.isGreaterThanCheckBox = new System.Windows.Forms.CheckBox();
            this.isLessThanCheckBox = new System.Windows.Forms.CheckBox();
            this.isGreaterThanOrEqualToCheckBox = new System.Windows.Forms.CheckBox();
            this.isLessThanOrEqualToCheckBox = new System.Windows.Forms.CheckBox();
            this.remainderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.radioButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // input1TextBox
            // 
            this.input1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1TextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input1TextBox.Location = new System.Drawing.Point(49, 44);
            this.input1TextBox.Name = "input1TextBox";
            this.input1TextBox.Size = new System.Drawing.Size(263, 27);
            this.input1TextBox.TabIndex = 0;
            this.input1TextBox.Text = "Enter a number";
            this.input1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input1TextBox.Click += new System.EventHandler(this.input1TextBox_Click);
            // 
            // input2TextBox
            // 
            this.input2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2TextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input2TextBox.Location = new System.Drawing.Point(49, 87);
            this.input2TextBox.Name = "input2TextBox";
            this.input2TextBox.Size = new System.Drawing.Size(263, 27);
            this.input2TextBox.TabIndex = 1;
            this.input2TextBox.Text = "Enter a number";
            this.input2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input2TextBox.Click += new System.EventHandler(this.input2TextBox_Click);
            // 
            // additionButton
            // 
            this.additionButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.additionButton.Location = new System.Drawing.Point(32, 159);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(134, 34);
            this.additionButton.TabIndex = 2;
            this.additionButton.Text = "Addition";
            this.additionButton.UseVisualStyleBackColor = false;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtractionButton.Location = new System.Drawing.Point(202, 159);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(134, 34);
            this.subtractionButton.TabIndex = 3;
            this.subtractionButton.Text = "Subtraction";
            this.subtractionButton.UseVisualStyleBackColor = false;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplicationButton.Location = new System.Drawing.Point(32, 222);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(134, 34);
            this.multiplicationButton.TabIndex = 4;
            this.multiplicationButton.Text = "Multiplication";
            this.multiplicationButton.UseVisualStyleBackColor = false;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divisionButton.Location = new System.Drawing.Point(202, 222);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(134, 34);
            this.divisionButton.TabIndex = 5;
            this.divisionButton.Text = "Division";
            this.divisionButton.UseVisualStyleBackColor = false;
            // 
            // isEqualToCheckBox
            // 
            this.isEqualToCheckBox.AutoSize = true;
            this.isEqualToCheckBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.isEqualToCheckBox.Enabled = false;
            this.isEqualToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isEqualToCheckBox.Location = new System.Drawing.Point(20, 29);
            this.isEqualToCheckBox.Name = "isEqualToCheckBox";
            this.isEqualToCheckBox.Size = new System.Drawing.Size(41, 24);
            this.isEqualToCheckBox.TabIndex = 6;
            this.isEqualToCheckBox.Text = "=";
            this.isEqualToCheckBox.UseVisualStyleBackColor = false;
            // 
            // isNotEqualToCheckBox
            // 
            this.isNotEqualToCheckBox.AutoSize = true;
            this.isNotEqualToCheckBox.Enabled = false;
            this.isNotEqualToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNotEqualToCheckBox.Location = new System.Drawing.Point(20, 59);
            this.isNotEqualToCheckBox.Name = "isNotEqualToCheckBox";
            this.isNotEqualToCheckBox.Size = new System.Drawing.Size(46, 24);
            this.isNotEqualToCheckBox.TabIndex = 7;
            this.isNotEqualToCheckBox.Text = "!=";
            this.isNotEqualToCheckBox.UseVisualStyleBackColor = true;
            // 
            // isGreaterThanCheckBox
            // 
            this.isGreaterThanCheckBox.AutoSize = true;
            this.isGreaterThanCheckBox.Enabled = false;
            this.isGreaterThanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isGreaterThanCheckBox.Location = new System.Drawing.Point(20, 89);
            this.isGreaterThanCheckBox.Name = "isGreaterThanCheckBox";
            this.isGreaterThanCheckBox.Size = new System.Drawing.Size(41, 24);
            this.isGreaterThanCheckBox.TabIndex = 8;
            this.isGreaterThanCheckBox.Text = ">";
            this.isGreaterThanCheckBox.UseVisualStyleBackColor = true;
            // 
            // isLessThanCheckBox
            // 
            this.isLessThanCheckBox.AutoSize = true;
            this.isLessThanCheckBox.Enabled = false;
            this.isLessThanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isLessThanCheckBox.Location = new System.Drawing.Point(131, 29);
            this.isLessThanCheckBox.Name = "isLessThanCheckBox";
            this.isLessThanCheckBox.Size = new System.Drawing.Size(41, 24);
            this.isLessThanCheckBox.TabIndex = 9;
            this.isLessThanCheckBox.Text = "<";
            this.isLessThanCheckBox.UseVisualStyleBackColor = true;
            // 
            // isGreaterThanOrEqualToCheckBox
            // 
            this.isGreaterThanOrEqualToCheckBox.AutoSize = true;
            this.isGreaterThanOrEqualToCheckBox.Enabled = false;
            this.isGreaterThanOrEqualToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isGreaterThanOrEqualToCheckBox.Location = new System.Drawing.Point(131, 59);
            this.isGreaterThanOrEqualToCheckBox.Name = "isGreaterThanOrEqualToCheckBox";
            this.isGreaterThanOrEqualToCheckBox.Size = new System.Drawing.Size(51, 24);
            this.isGreaterThanOrEqualToCheckBox.TabIndex = 10;
            this.isGreaterThanOrEqualToCheckBox.Text = ">=";
            this.isGreaterThanOrEqualToCheckBox.UseVisualStyleBackColor = true;
            // 
            // isLessThanOrEqualToCheckBox
            // 
            this.isLessThanOrEqualToCheckBox.AutoSize = true;
            this.isLessThanOrEqualToCheckBox.Enabled = false;
            this.isLessThanOrEqualToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isLessThanOrEqualToCheckBox.Location = new System.Drawing.Point(131, 89);
            this.isLessThanOrEqualToCheckBox.Name = "isLessThanOrEqualToCheckBox";
            this.isLessThanOrEqualToCheckBox.Size = new System.Drawing.Size(51, 24);
            this.isLessThanOrEqualToCheckBox.TabIndex = 11;
            this.isLessThanOrEqualToCheckBox.Text = "<=";
            this.isLessThanOrEqualToCheckBox.UseVisualStyleBackColor = true;
            // 
            // remainderButton
            // 
            this.remainderButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remainderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remainderButton.Location = new System.Drawing.Point(117, 279);
            this.remainderButton.Name = "remainderButton";
            this.remainderButton.Size = new System.Drawing.Size(134, 34);
            this.remainderButton.TabIndex = 12;
            this.remainderButton.Text = "Remainder";
            this.remainderButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(117, 514);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 34);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(46, 462);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(263, 35);
            this.displayLabel.TabIndex = 14;
            this.displayLabel.Text = "Result here";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonsGroupBox
            // 
            this.radioButtonsGroupBox.Controls.Add(this.isEqualToCheckBox);
            this.radioButtonsGroupBox.Controls.Add(this.isNotEqualToCheckBox);
            this.radioButtonsGroupBox.Controls.Add(this.isGreaterThanCheckBox);
            this.radioButtonsGroupBox.Controls.Add(this.isLessThanCheckBox);
            this.radioButtonsGroupBox.Controls.Add(this.isLessThanOrEqualToCheckBox);
            this.radioButtonsGroupBox.Controls.Add(this.isGreaterThanOrEqualToCheckBox);
            this.radioButtonsGroupBox.Location = new System.Drawing.Point(90, 319);
            this.radioButtonsGroupBox.Name = "radioButtonsGroupBox";
            this.radioButtonsGroupBox.Size = new System.Drawing.Size(192, 128);
            this.radioButtonsGroupBox.TabIndex = 15;
            this.radioButtonsGroupBox.TabStop = false;
            this.radioButtonsGroupBox.Text = "Comparison";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(363, 584);
            this.Controls.Add(this.radioButtonsGroupBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.remainderButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.input2TextBox);
            this.Controls.Add(this.input1TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "Huge Integer";
            this.radioButtonsGroupBox.ResumeLayout(false);
            this.radioButtonsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1TextBox;
        private System.Windows.Forms.TextBox input2TextBox;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.CheckBox isEqualToCheckBox;
        private System.Windows.Forms.CheckBox isNotEqualToCheckBox;
        private System.Windows.Forms.CheckBox isGreaterThanCheckBox;
        private System.Windows.Forms.CheckBox isLessThanCheckBox;
        private System.Windows.Forms.CheckBox isGreaterThanOrEqualToCheckBox;
        private System.Windows.Forms.CheckBox isLessThanOrEqualToCheckBox;
        private System.Windows.Forms.Button remainderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.GroupBox radioButtonsGroupBox;
    }
}