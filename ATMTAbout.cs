using System;
using System.Windows.Forms;

public class ATMTAbout : Form
{
    private Label productNameLabel;
    private Label versionLabel;
    private Label copyrightLabel;
    private Label label1;

    public ATMTAbout()
	{
        InitializeComponent();
	}

    private void InitializeComponent()
    {
            this.productNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(15, 15);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(285, 12);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name : Automotive Threat Modeling Tool";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(15, 40);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(86, 12);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version : 1.0.0";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(15, 65);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(125, 12);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright : SANELab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Affiliation : Korea University";
            // 
            // ATMTAbout
            // 
            this.ClientSize = new System.Drawing.Size(311, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.productNameLabel);
            this.Name = "ATMTAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
