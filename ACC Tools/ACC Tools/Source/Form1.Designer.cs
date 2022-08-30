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
			this.WeatherList = new System.Windows.Forms.ListBox();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.StartStopButton = new System.Windows.Forms.Button();
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
			this.StatusLabel.Size = new System.Drawing.Size(89, 17);
			this.StatusLabel.Text = "Status: Stopped";
			// 
			// WeatherList
			// 
			this.WeatherList.FormattingEnabled = true;
			this.WeatherList.ItemHeight = 15;
			this.WeatherList.Items.AddRange(new object[] {
            "Current Weather:"});
			this.WeatherList.Location = new System.Drawing.Point(12, 27);
			this.WeatherList.Name = "WeatherList";
			this.WeatherList.Size = new System.Drawing.Size(120, 94);
			this.WeatherList.TabIndex = 2;
			// 
			// SettingsButton
			// 
			this.SettingsButton.Location = new System.Drawing.Point(713, 12);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(75, 23);
			this.SettingsButton.TabIndex = 3;
			this.SettingsButton.Text = "Settings";
			this.SettingsButton.UseVisualStyleBackColor = true;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// StartStopButton
			// 
			this.StartStopButton.Location = new System.Drawing.Point(713, 41);
			this.StartStopButton.Name = "StartStopButton";
			this.StartStopButton.Size = new System.Drawing.Size(75, 23);
			this.StartStopButton.TabIndex = 4;
			this.StartStopButton.Text = "Start";
			this.StartStopButton.UseVisualStyleBackColor = true;
			this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.StartStopButton);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.WeatherList);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.TrackStatusLabel);
			this.Name = "Form1";
			this.Text = "ACCTools";
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private Label TrackStatusLabel;
    private StatusStrip StatusStrip;
    private ToolStripStatusLabel StatusLabel;
	private ListBox WeatherList;
	private Button SettingsButton;
	private Button StartStopButton;
}