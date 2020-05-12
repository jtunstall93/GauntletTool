using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GauntletTool
{
	public partial class Form2 : Form
	{
		private bool values = false;
		Form1 parent;

		public Form2(Form1 p)
		{
			InitializeComponent();
			parent = p;
		}

		private void assignValuesButton_Click(object sender, EventArgs e)
		{
			if (WF_Min.Value < WF_Max.Value && Ore_Min.Value < Ore_Max.Value && Bark_Min.Value < Bark_Max.Value
				&& Wool_Min.Value < Wool_Max.Value && GL_Min.Value < GL_Max.Value && Food_Min.Value < Food_Max.Value && Shards_Min.Value < Shards_Max.Value)
			{
				string filePath = Directory.GetCurrentDirectory();
				filePath += "\\prefs";

				Directory.CreateDirectory(filePath);

				filePath += "\\custom.txt";

				StreamWriter writer = new StreamWriter(filePath);

				//order: Wep frame min, wep frame max || ore min, ore max || bark min, bark max || wool min, wool max || grym Leaves min, grym leaves max || food min, food max || shard min, shard max

				//writer.WriteLine("Custom");
				writer.WriteLine(WF_Min.Value);
				writer.WriteLine(WF_Max.Value);
				//
				writer.WriteLine(Ore_Min.Value);
				writer.WriteLine(Ore_Max.Value);
				//
				writer.WriteLine(Bark_Min.Value);
				writer.WriteLine(Bark_Max.Value);
				//
				writer.WriteLine(Wool_Min.Value);
				writer.WriteLine(Wool_Max.Value);
				//
				writer.WriteLine(GL_Min.Value);
				writer.WriteLine(GL_Max.Value);
				//
				writer.WriteLine(Food_Min.Value);
				writer.WriteLine(Food_Max.Value);
				//
				writer.WriteLine(Shards_Min.Value);
				writer.WriteLine(Shards_Max.Value);

				writer.Close();

				values = true;

				Form3 valuesSavedForm = new Form3(this, false);
				valuesSavedForm.Activate();
				valuesSavedForm.ShowDialog();

				ChangeProgressBounds();
			}
			else
			{
				values = false;
				Form3 invalidValuesForm = new Form3(this, false);
				invalidValuesForm.Activate();
				invalidValuesForm.ShowDialog();
			}
		}

		private void DefaultValuesButton_Click(object sender, EventArgs e)
		{
			string filePath = Directory.GetCurrentDirectory();

			filePath += "\\prefs";

			Directory.CreateDirectory(filePath);

			filePath += "\\default.txt";

			if (File.Exists(filePath))
			{
				StreamReader reader = new StreamReader(filePath);
				//
				WF_Min.Value = Convert.ToInt32(reader.ReadLine());
				WF_Max.Value = Convert.ToInt32(reader.ReadLine());
				//
				Ore_Min.Value = Convert.ToInt32(reader.ReadLine());
				Ore_Max.Value = Convert.ToInt32(reader.ReadLine());
				//
				Bark_Min.Value = Convert.ToInt32(reader.ReadLine());
				Bark_Max.Value = Convert.ToInt32(reader.ReadLine());
				//
				Wool_Min.Value = Convert.ToInt32(reader.ReadLine());
				Wool_Max.Value = Convert.ToInt32(reader.ReadLine());
				//
				GL_Min.Value = Convert.ToInt32(reader.ReadLine());
				GL_Max.Value = Convert.ToInt32(reader.ReadLine());
				//
				Food_Min.Value = Convert.ToInt32(reader.ReadLine());
				Food_Max.Value = Convert.ToInt32(reader.ReadLine());
				//
				Shards_Min.Value = Convert.ToInt32(reader.ReadLine());
				Shards_Max.Value = Convert.ToInt32(reader.ReadLine());

				reader.Close();
				ChangeProgressBounds();

				Form3 valuesSavedForm = new Form3(this, true);
				valuesSavedForm.Activate();
				valuesSavedForm.ShowDialog();
			}
		}

		public bool GetValues() { return values; }

		private void ChangeProgressBounds()
		{
			ProgressBar WF = (ProgressBar)(parent.Controls["WF_Bar"]);
			ProgressBar Ore = (ProgressBar)(parent.Controls["Ore_Bar"]);
			ProgressBar Bark = (ProgressBar)(parent.Controls["Bark_Bar"]);
			ProgressBar Wool = (ProgressBar)(parent.Controls["Wool_Bar"]);
			ProgressBar GL = (ProgressBar)(parent.Controls["GL_Bar"]);
			ProgressBar Food = (ProgressBar)(parent.Controls["Food_Bar"]);
			ProgressBar Shards = (ProgressBar)(parent.Controls["Shard_Bar"]);

			WF.Minimum = (int)WF_Min.Value;
			WF.Maximum = (int)WF_Max.Value;
			//
			Ore.Minimum = (int)Ore_Min.Value;
			Ore.Maximum = (int)Ore_Max.Value;
			//
			Bark.Minimum = (int)Bark_Min.Value;
			Bark.Maximum = (int)Bark_Max.Value;
			//
			Wool.Minimum = (int)Wool_Min.Value;
			Wool.Maximum = (int)Wool_Max.Value;
			//
			GL.Minimum = (int)GL_Min.Value;
			GL.Maximum = (int)GL_Max.Value;
			//
			Food.Minimum = (int)Food_Min.Value;
			Food.Maximum = (int)Food_Max.Value;
			//
			Shards.Minimum = (int)Shards_Min.Value;
			Shards.Maximum = (int)Shards_Max.Value;
		}
	}

}
