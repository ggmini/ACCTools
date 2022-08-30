namespace ACC_Tools.Source
{
	partial class SettingsForm
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
			this.StaticIntervalLabel = new System.Windows.Forms.Label();
			this.GraphicsIntervalLabel = new System.Windows.Forms.Label();
			this.PhysicsIntervalLabel = new System.Windows.Forms.Label();
			this.StaticInfoTextBox = new System.Windows.Forms.TextBox();
			this.GraphicTextBox = new System.Windows.Forms.TextBox();
			this.PhysicsTextBox = new System.Windows.Forms.TextBox();
			this.msLabel1 = new System.Windows.Forms.Label();
			this.msLabel2 = new System.Windows.Forms.Label();
			this.msLabel3 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.RestoreButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StaticIntervalLabel
			// 
			this.StaticIntervalLabel.AutoSize = true;
			this.StaticIntervalLabel.Location = new System.Drawing.Point(8, 7);
			this.StaticIntervalLabel.Name = "StaticIntervalLabel";
			this.StaticIntervalLabel.Size = new System.Drawing.Size(143, 15);
			this.StaticIntervalLabel.TabIndex = 0;
			this.StaticIntervalLabel.Text = "Static Info Update Interval";
			// 
			// GraphicsIntervalLabel
			// 
			this.GraphicsIntervalLabel.AutoSize = true;
			this.GraphicsIntervalLabel.Location = new System.Drawing.Point(8, 36);
			this.GraphicsIntervalLabel.Name = "GraphicsIntervalLabel";
			this.GraphicsIntervalLabel.Size = new System.Drawing.Size(136, 15);
			this.GraphicsIntervalLabel.TabIndex = 1;
			this.GraphicsIntervalLabel.Text = "Graphics Update Interval";
			// 
			// PhysicsIntervalLabel
			// 
			this.PhysicsIntervalLabel.AutoSize = true;
			this.PhysicsIntervalLabel.Location = new System.Drawing.Point(8, 65);
			this.PhysicsIntervalLabel.Name = "PhysicsIntervalLabel";
			this.PhysicsIntervalLabel.Size = new System.Drawing.Size(129, 15);
			this.PhysicsIntervalLabel.TabIndex = 2;
			this.PhysicsIntervalLabel.Text = "Physics Update Interval";
			// 
			// StaticInfoTextBox
			// 
			this.StaticInfoTextBox.Location = new System.Drawing.Point(157, 4);
			this.StaticInfoTextBox.Name = "StaticInfoTextBox";
			this.StaticInfoTextBox.Size = new System.Drawing.Size(100, 23);
			this.StaticInfoTextBox.TabIndex = 3;
			// 
			// GraphicTextBox
			// 
			this.GraphicTextBox.Location = new System.Drawing.Point(157, 33);
			this.GraphicTextBox.Name = "GraphicTextBox";
			this.GraphicTextBox.Size = new System.Drawing.Size(100, 23);
			this.GraphicTextBox.TabIndex = 4;
			// 
			// PhysicsTextBox
			// 
			this.PhysicsTextBox.Location = new System.Drawing.Point(157, 62);
			this.PhysicsTextBox.Name = "PhysicsTextBox";
			this.PhysicsTextBox.Size = new System.Drawing.Size(100, 23);
			this.PhysicsTextBox.TabIndex = 5;
			// 
			// msLabel1
			// 
			this.msLabel1.AutoSize = true;
			this.msLabel1.Location = new System.Drawing.Point(263, 7);
			this.msLabel1.Name = "msLabel1";
			this.msLabel1.Size = new System.Drawing.Size(23, 15);
			this.msLabel1.TabIndex = 6;
			this.msLabel1.Text = "ms";
			// 
			// msLabel2
			// 
			this.msLabel2.AutoSize = true;
			this.msLabel2.Location = new System.Drawing.Point(263, 36);
			this.msLabel2.Name = "msLabel2";
			this.msLabel2.Size = new System.Drawing.Size(23, 15);
			this.msLabel2.TabIndex = 7;
			this.msLabel2.Text = "ms";
			// 
			// msLabel3
			// 
			this.msLabel3.AutoSize = true;
			this.msLabel3.Location = new System.Drawing.Point(263, 65);
			this.msLabel3.Name = "msLabel3";
			this.msLabel3.Size = new System.Drawing.Size(23, 15);
			this.msLabel3.TabIndex = 8;
			this.msLabel3.Text = "ms";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(292, 4);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(100, 23);
			this.SaveButton.TabIndex = 9;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// RestoreButton
			// 
			this.RestoreButton.Location = new System.Drawing.Point(292, 61);
			this.RestoreButton.Name = "RestoreButton";
			this.RestoreButton.Size = new System.Drawing.Size(100, 23);
			this.RestoreButton.TabIndex = 10;
			this.RestoreButton.Text = "Restore Defaults";
			this.RestoreButton.UseVisualStyleBackColor = true;
			this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 89);
			this.Controls.Add(this.RestoreButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.msLabel3);
			this.Controls.Add(this.msLabel2);
			this.Controls.Add(this.msLabel1);
			this.Controls.Add(this.PhysicsTextBox);
			this.Controls.Add(this.GraphicTextBox);
			this.Controls.Add(this.StaticInfoTextBox);
			this.Controls.Add(this.PhysicsIntervalLabel);
			this.Controls.Add(this.GraphicsIntervalLabel);
			this.Controls.Add(this.StaticIntervalLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label StaticIntervalLabel;
		private Label GraphicsIntervalLabel;
		private Label PhysicsIntervalLabel;
		private TextBox StaticInfoTextBox;
		private TextBox GraphicTextBox;
		private TextBox PhysicsTextBox;
		private Label msLabel1;
		private Label msLabel2;
		private Label msLabel3;
		private Button SaveButton;
		private Button RestoreButton;
	}
}