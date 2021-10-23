
namespace HugeInteger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.input2TextBox = new System.Windows.Forms.TextBox();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.isEqualToRadioButton = new System.Windows.Forms.RadioButton();
            this.isNotEqualToRadioButton = new System.Windows.Forms.RadioButton();
            this.isGreaterThan = new System.Windows.Forms.RadioButton();
            this.isLessThanRadioButton = new System.Windows.Forms.RadioButton();
            this.isGreaterThanOrEqualToRadioButton = new System.Windows.Forms.RadioButton();
            this.isLessThanOrEqualToRadioButton = new System.Windows.Forms.RadioButton();
            this.remainderButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
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
            // isEqualToRadioButton
            // 
            this.isEqualToRadioButton.AutoSize = true;
            this.isEqualToRadioButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.isEqualToRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isEqualToRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.isEqualToRadioButton.Location = new System.Drawing.Point(109, 342);
            this.isEqualToRadioButton.Name = "isEqualToRadioButton";
            this.isEqualToRadioButton.Size = new System.Drawing.Size(40, 24);
            this.isEqualToRadioButton.TabIndex = 6;
            this.isEqualToRadioButton.TabStop = true;
            this.isEqualToRadioButton.Text = "=";
            this.isEqualToRadioButton.UseVisualStyleBackColor = false;
            // 
            // isNotEqualToRadioButton
            // 
            this.isNotEqualToRadioButton.AutoSize = true;
            this.isNotEqualToRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNotEqualToRadioButton.Location = new System.Drawing.Point(109, 372);
            this.isNotEqualToRadioButton.Name = "isNotEqualToRadioButton";
            this.isNotEqualToRadioButton.Size = new System.Drawing.Size(45, 24);
            this.isNotEqualToRadioButton.TabIndex = 7;
            this.isNotEqualToRadioButton.TabStop = true;
            this.isNotEqualToRadioButton.Text = "!=";
            this.isNotEqualToRadioButton.UseVisualStyleBackColor = true;
            // 
            // isGreaterThan
            // 
            this.isGreaterThan.AutoSize = true;
            this.isGreaterThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isGreaterThan.Location = new System.Drawing.Point(109, 402);
            this.isGreaterThan.Name = "isGreaterThan";
            this.isGreaterThan.Size = new System.Drawing.Size(40, 24);
            this.isGreaterThan.TabIndex = 8;
            this.isGreaterThan.TabStop = true;
            this.isGreaterThan.Text = ">";
            this.isGreaterThan.UseVisualStyleBackColor = true;
            // 
            // isLessThanRadioButton
            // 
            this.isLessThanRadioButton.AutoSize = true;
            this.isLessThanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isLessThanRadioButton.Location = new System.Drawing.Point(211, 342);
            this.isLessThanRadioButton.Name = "isLessThanRadioButton";
            this.isLessThanRadioButton.Size = new System.Drawing.Size(40, 24);
            this.isLessThanRadioButton.TabIndex = 9;
            this.isLessThanRadioButton.TabStop = true;
            this.isLessThanRadioButton.Text = "<";
            this.isLessThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // isGreaterThanOrEqualToRadioButton
            // 
            this.isGreaterThanOrEqualToRadioButton.AutoSize = true;
            this.isGreaterThanOrEqualToRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isGreaterThanOrEqualToRadioButton.Location = new System.Drawing.Point(211, 372);
            this.isGreaterThanOrEqualToRadioButton.Name = "isGreaterThanOrEqualToRadioButton";
            this.isGreaterThanOrEqualToRadioButton.Size = new System.Drawing.Size(50, 24);
            this.isGreaterThanOrEqualToRadioButton.TabIndex = 10;
            this.isGreaterThanOrEqualToRadioButton.TabStop = true;
            this.isGreaterThanOrEqualToRadioButton.Text = ">=";
            this.isGreaterThanOrEqualToRadioButton.UseVisualStyleBackColor = true;
            // 
            // isLessThanOrEqualToRadioButton
            // 
            this.isLessThanOrEqualToRadioButton.AutoSize = true;
            this.isLessThanOrEqualToRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isLessThanOrEqualToRadioButton.Location = new System.Drawing.Point(211, 402);
            this.isLessThanOrEqualToRadioButton.Name = "isLessThanOrEqualToRadioButton";
            this.isLessThanOrEqualToRadioButton.Size = new System.Drawing.Size(50, 24);
            this.isLessThanOrEqualToRadioButton.TabIndex = 11;
            this.isLessThanOrEqualToRadioButton.TabStop = true;
            this.isLessThanOrEqualToRadioButton.Text = "<=";
            this.isLessThanOrEqualToRadioButton.UseVisualStyleBackColor = true;
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
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateButton.Location = new System.Drawing.Point(117, 442);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(134, 34);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(49, 488);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(263, 35);
            this.displayLabel.TabIndex = 14;
            this.displayLabel.Text = "Result here";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(361, 532);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.remainderButton);
            this.Controls.Add(this.isLessThanOrEqualToRadioButton);
            this.Controls.Add(this.isGreaterThanOrEqualToRadioButton);
            this.Controls.Add(this.isLessThanRadioButton);
            this.Controls.Add(this.isGreaterThan);
            this.Controls.Add(this.isNotEqualToRadioButton);
            this.Controls.Add(this.isEqualToRadioButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.input2TextBox);
            this.Controls.Add(this.input1TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Huge Integer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1TextBox;
        private System.Windows.Forms.TextBox input2TextBox;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.RadioButton isEqualToRadioButton;
        private System.Windows.Forms.RadioButton isNotEqualToRadioButton;
        private System.Windows.Forms.RadioButton isGreaterThan;
        private System.Windows.Forms.RadioButton isLessThanRadioButton;
        private System.Windows.Forms.RadioButton isGreaterThanOrEqualToRadioButton;
        private System.Windows.Forms.RadioButton isLessThanOrEqualToRadioButton;
        private System.Windows.Forms.Button remainderButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button additionButton;
    }
}

