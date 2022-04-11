
namespace PigeonAssetManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftBar = new System.Windows.Forms.Panel();
            this.ImportAssetsButton = new System.Windows.Forms.Button();
            this.LoanAssetButton = new System.Windows.Forms.Button();
            this.AlertsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Alertslabel = new System.Windows.Forms.Label();
            this.LeftBar.SuspendLayout();
            this.AlertsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBar.AutoSize = true;
            this.LeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.LeftBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftBar.Controls.Add(this.ImportAssetsButton);
            this.LeftBar.Controls.Add(this.LoanAssetButton);
            this.LeftBar.Location = new System.Drawing.Point(0, 0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(243, 684);
            this.LeftBar.TabIndex = 0;
            // 
            // ImportAssetsButton
            // 
            this.ImportAssetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ImportAssetsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImportAssetsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImportAssetsButton.Location = new System.Drawing.Point(0, 45);
            this.ImportAssetsButton.Name = "ImportAssetsButton";
            this.ImportAssetsButton.Size = new System.Drawing.Size(241, 45);
            this.ImportAssetsButton.TabIndex = 1;
            this.ImportAssetsButton.Text = "Import";
            this.ImportAssetsButton.UseVisualStyleBackColor = false;
            // 
            // LoanAssetButton
            // 
            this.LoanAssetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.LoanAssetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoanAssetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoanAssetButton.Location = new System.Drawing.Point(0, 0);
            this.LoanAssetButton.Name = "LoanAssetButton";
            this.LoanAssetButton.Size = new System.Drawing.Size(241, 45);
            this.LoanAssetButton.TabIndex = 0;
            this.LoanAssetButton.Text = "Loan Asset";
            this.LoanAssetButton.UseVisualStyleBackColor = false;
            // 
            // AlertsPanel
            // 
            this.AlertsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.AlertsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlertsPanel.Controls.Add(this.panel1);
            this.AlertsPanel.Location = new System.Drawing.Point(933, 1);
            this.AlertsPanel.Name = "AlertsPanel";
            this.AlertsPanel.Size = new System.Drawing.Size(330, 683);
            this.AlertsPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.Alertslabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 59);
            this.panel1.TabIndex = 1;
            // 
            // Alertslabel
            // 
            this.Alertslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Alertslabel.AutoSize = true;
            this.Alertslabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alertslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Alertslabel.Location = new System.Drawing.Point(146, 17);
            this.Alertslabel.Name = "Alertslabel";
            this.Alertslabel.Size = new System.Drawing.Size(57, 25);
            this.Alertslabel.TabIndex = 0;
            this.Alertslabel.Text = "Alerts";
            this.Alertslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Alertslabel.Click += new System.EventHandler(this.Alertslabel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AlertsPanel);
            this.Controls.Add(this.LeftBar);
            this.Name = "Main";
            this.Text = "Asset Pigeon";
            this.Load += new System.EventHandler(this.Main_Load);
            this.LeftBar.ResumeLayout(false);
            this.AlertsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftBar;
        private System.Windows.Forms.Button LoanAssetButton;
        private System.Windows.Forms.Button ImportAssetsButton;
        private System.Windows.Forms.Panel AlertsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Alertslabel;
    }
}

