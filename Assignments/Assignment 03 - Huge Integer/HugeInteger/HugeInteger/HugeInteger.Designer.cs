
namespace HugeInteger
{
    partial class HugeInteger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HugeInteger));
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1TextBox
            // 
            this.num1TextBox.AcceptsReturn = true;
            this.num1TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.num1TextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.num1TextBox.Location = new System.Drawing.Point(48, 30);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(286, 22);
            this.num1TextBox.TabIndex = 0;
            this.num1TextBox.Text = "Enter a number";
            this.num1TextBox.Click += new System.EventHandler(this.num1TextBox_Click);
            // 
            // num2TextBox
            // 
            this.num2TextBox.AcceptsReturn = true;
            this.num2TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.num2TextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.num2TextBox.Location = new System.Drawing.Point(48, 82);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(286, 22);
            this.num2TextBox.TabIndex = 1;
            this.num2TextBox.Text = "Enter another number";
            this.num2TextBox.Click += new System.EventHandler(this.num2TextBox_Click);
            // 
            // additionButton
            // 
            this.additionButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.additionButton.Location = new System.Drawing.Point(36, 160);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(119, 44);
            this.additionButton.TabIndex = 2;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = false;
            // 
            // subtractionButton
            // 
            this.subtractionButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtractionButton.Location = new System.Drawing.Point(187, 160);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(122, 44);
            this.subtractionButton.TabIndex = 3;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = false;
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplicationButton.Location = new System.Drawing.Point(36, 237);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(119, 43);
            this.multiplicationButton.TabIndex = 4;
            this.multiplicationButton.Text = "×";
            this.multiplicationButton.UseVisualStyleBackColor = false;
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divisionButton.Location = new System.Drawing.Point(187, 237);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(122, 43);
            this.divisionButton.TabIndex = 5;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
    }
}

