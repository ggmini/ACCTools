namespace ACC_Tools;

partial class Form1
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
			this.TrackStatusLabel = new System.Windows.Forms.Label();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TrackStatusLabel
			// 
			this.TrackStatusLabel.AutoSize = true;
			this.TrackStatusLabel.Location = new System.Drawing.Point(12, 9);
			this.TrackStatusLabel.Name = "TrackStatusLabel";
			this.TrackStatusLabel.Size = new System.Drawing.Size(75, 15);
			this.TrackStatusLabel.TabIndex = 0;
			this.TrackStatusLabel.Text = "Track Status: ";
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 428);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(800, 22);
			this.StatusStrip.TabIndex = 1;
			// 
			// StatusLabel
			// 
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(126, 17);
			this.StatusLabel.Text = "Status: Not Connected";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.TrackStatusLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private Label TrackStatusLabel;
    private StatusStrip StatusStrip;
    private ToolStripStatusLabel StatusLabel;
}