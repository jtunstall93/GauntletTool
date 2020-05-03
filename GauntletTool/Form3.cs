using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GauntletTool
{
	public partial class Form3 : Form
	{
		private Form2 parent;

		public Form3(Form2 p)
		{
			InitializeComponent();
			parent = p;

			if (parent.GetValues())
				valuesLabel.Text = "Values assigned.";
			else
				valuesLabel.Text = "Invalid values.";
			
		}

		private void okayButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void valuesLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
