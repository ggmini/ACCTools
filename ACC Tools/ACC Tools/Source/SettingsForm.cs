using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACC_Tools.Source
{
	public partial class SettingsForm : Form
	{
		Form1 mainForm;

		public SettingsForm(Form1 mainForm)
		{
			this.mainForm = mainForm;
			double[] intervals = mainForm.GetUpdateIntervals();
				
			InitializeComponent();

			StaticInfoTextBox.Text = intervals[0].ToString();
			GraphicTextBox.Text = intervals[1].ToString();
			PhysicsTextBox.Text = intervals[2].ToString();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			mainForm.SetUpdateIntervals(Convert.ToDouble(StaticInfoTextBox.Text), Convert.ToDouble(GraphicTextBox.Text), Convert.ToDouble(PhysicsTextBox.Text));
		}

		private void RestoreButton_Click(object sender, EventArgs e)
		{
			StaticInfoTextBox.Text = 1000.ToString();
			GraphicTextBox.Text = 1000.ToString();
			PhysicsTextBox.Text = 10.ToString();
		}
	}
}
