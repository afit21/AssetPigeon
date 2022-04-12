
namespace PigeonAssetManager
{
    partial class Setup
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
            this.CredentialsButton = new System.Windows.Forms.Button();
            this.SheetIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CredentialsButton
            // 
            this.CredentialsButton.Location = new System.Drawing.Point(12, 85);
            this.CredentialsButton.Name = "CredentialsButton";
            this.CredentialsButton.Size = new System.Drawing.Size(152, 41);
            this.CredentialsButton.TabIndex = 0;
            this.CredentialsButton.Text = "Select Credentials.json";
            this.CredentialsButton.UseVisualStyleBackColor = true;
            this.CredentialsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SheetIdBox
            // 
            this.SheetIdBox.Location = new System.Drawing.Point(12, 35);
            this.SheetIdBox.Name = "SheetIdBox";
            this.SheetIdBox.Size = new System.Drawing.Size(347, 23);
            this.SheetIdBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spreadsheet ID";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(13, 174);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.TabStop = false;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SheetIdBox);
            this.Controls.Add(this.CredentialsButton);
            this.Name = "Setup";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CredentialsButton;
        private System.Windows.Forms.TextBox SheetIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishButton;
    }
}