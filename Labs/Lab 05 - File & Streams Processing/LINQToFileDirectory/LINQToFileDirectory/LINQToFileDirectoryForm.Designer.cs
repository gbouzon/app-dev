
namespace LINQToFileDirectory
{
    partial class LINQToFileDirectoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter path to search:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(26, 53);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(346, 22);
            this.pathTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(200, 92);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search Directory";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory:";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(111, 140);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(261, 22);
            this.directoryTextBox.TabIndex = 4;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(37, 183);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.resultsTextBox.Size = new System.Drawing.Size(335, 256);
            this.resultsTextBox.TabIndex = 5;
            this.resultsTextBox.Text = "";
            // 
            // LINQToFileDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 473);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LINQToFileDirectoryForm";
            this.Text = "Search Directories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.RichTextBox resultsTextBox;
    }
}

