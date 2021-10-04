
namespace LabelTextBoxButtonTest
{
    partial class LabelTextBoxButtonTestForm
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
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPasswordTextBox.Location = new System.Drawing.Point(57, 28);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(400, 22);
            this.inputPasswordTextBox.TabIndex = 0;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPasswordLabel.Location = new System.Drawing.Point(57, 71);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(400, 23);
            this.displayPasswordLabel.TabIndex = 1;
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(203, 108);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.displayPasswordButton.TabIndex = 2;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // LabelTextBoxButtonTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 152);
            this.Controls.Add(this.displayPasswordButton);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Name = "LabelTextBoxButtonTestForm";
            this.Text = "Label, TextBox and Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.Button displayPasswordButton;
    }
}

