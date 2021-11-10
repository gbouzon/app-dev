
namespace ReadFile
{
    partial class ReadFileForm
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
            this.openButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(35, 284);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(133, 57);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(192, 284);
            this.nextButton.Name = "nextButton";
            this.nextButton.Enabled = false;
            this.nextButton.Size = new System.Drawing.Size(133, 57);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next Record";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 384);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.openButton);
            this.Name = "ReadSequentialAccessFileForm";
            this.Text = "Reading a Sequential File";
            this.Controls.SetChildIndex(this.openButton, 0);
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button nextButton;
    }
}