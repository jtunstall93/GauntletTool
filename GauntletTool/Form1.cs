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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DefaultBackup();
			LoadCustomBoundsOnStart();
		}

		private void WF_Count_ValueChanged(object sender, EventArgs e)
		{
			WF_Bar.Value = Progress_Adjust((int)WF_Count.Value, WF_Bar.Maximum, WF_Bar.Minimum, WF_Bar.Value);
		}

		private void Ore_Count_ValueChanged(object sender, EventArgs e)
		{
			Ore_Bar.Value = Progress_Adjust((int)Ore_Count.Value, Ore_Bar.Maximum, Ore_Bar.Minimum, Ore_Bar.Value);
		}

		private void Bark_Count_ValueChanged(object sender, EventArgs e)
		{
			Bark_Bar.Value = Progress_Adjust((int)Bark_Count.Value, Bark_Bar.Maximum, Bark_Bar.Minimum, Bark_Bar.Value);
		}

		private void Wool_Count_ValueChanged(object sender, EventArgs e)
		{
			Wool_Bar.Value = Progress_Adjust((int)Wool_Count.Value, Wool_Bar.Maximum, Wool_Bar.Minimum, Wool_Bar.Value);
		}

		private void GL_Count_ValueChanged(object sender, EventArgs e)
		{
			GL_Bar.Value = Progress_Adjust((int)GL_Count.Value, GL_Bar.Maximum, GL_Bar.Minimum, GL_Bar.Value);
		}

		private void Food_Count_ValueChanged(object sender, EventArgs e)
		{
			Food_Bar.Value = Progress_Adjust((int)Food_Count.Value, Food_Bar.Maximum, Food_Bar.Minimum, Food_Bar.Value);
		}

		private void Shard_Count_ValueChanged(object sender, EventArgs e)
		{
			Shard_Bar.Value = Progress_Adjust((int)Shard_Count.Value, Shard_Bar.Maximum, Shard_Bar.Minimum, Shard_Bar.Value);
		}

		private void Gear_Box_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int checkCount = 0;

			for (int i = 0; i < Gear_Box.Items.Count; i++)
			{
				if (Gear_Box.GetItemChecked(i))
					checkCount += 1;
			}

			if (e.NewValue == CheckState.Checked)
				checkCount += 1;
			else
				checkCount -= 1;

			if (checkCount == Gear_Box.Items.Count && T3_Wep_Attachment.CheckedItems.Count >= 2)
				label8.Visible = true;
			else
				label8.Visible = false;
		}

		private void T3_Wep_Attachment_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int checkCount = 0;

			for (int i = 0; i < T3_Wep_Attachment.Items.Count; i++)
			{
				if (T3_Wep_Attachment.GetItemChecked(i))
					checkCount += 1;
			}

			if (e.NewValue == CheckState.Checked)
				checkCount += 1;
			else
				checkCount -= 1;

			if (checkCount >= 2 && Gear_Box.CheckedItems.Count == Gear_Box.Items.Count)
				label8.Visible = true;
			else
				label8.Visible = false;
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < Gear_Box.Items.Count; i++)
				Gear_Box.SetItemCheckState(i, CheckState.Unchecked);

			for (int i = 0; i < T3_Wep_Attachment.Items.Count; i++)
				T3_Wep_Attachment.SetItemCheckState(i, CheckState.Unchecked);

			WF_Count.Value = 0;
			WF_Bar.Value = 0;

			Ore_Count.Value = 0;
			Ore_Bar.Value = 0;

			Bark_Count.Value = 0;
			Bark_Bar.Value = 0;

			Wool_Count.Value = 0;
			Wool_Bar.Value = 0;

			GL_Count.Value = 0;
			GL_Bar.Value = 0;

			Food_Count.Value = 0;
			Food_Bar.Value = 0;

			Shard_Count.Value = 0;
			Shard_Bar.Value = 0;
		}

		private void customBoundsButton_Click(object sender, EventArgs e)
		{
			Form2 customBoundsForm = new Form2(this);
			customBoundsForm.Activate();
			customBoundsForm.ShowDialog();
		}

		/// <summary>
		/// Function to compare and set progress bar values.
		/// </summary>
		/// <param name="iCount">The current count of the corresponding number bar value.</param>
		/// <param name="progMax">The maximum value of the progress bar.</param>
		/// <param name="progMin">The minimum value of the progress bar.</param>
		/// <param name="pCount">The current value of the progress bar.</param>
		/// <returns></returns>
		private int Progress_Adjust(int iCount, int progMax, int progMin, int pCount)
		{
			if (iCount <= progMax && iCount >= progMin)
				return iCount;
			else
				return pCount;
		}

		/// <summary>
		/// This function will check for a custom.txt file in the prefs folder, and if it finds one, will load in the values saved there.
		/// </summary>
		private void LoadCustomBoundsOnStart()
		{
			string filePath = Directory.GetCurrentDirectory();
			filePath += "\\prefs\\custom.txt";

			if (File.Exists(filePath))
			{

				StreamReader reader = new StreamReader(filePath);
				WF_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				WF_Bar.Maximum = Convert.ToInt32(reader.ReadLine());
				//
				Ore_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				Ore_Bar.Maximum = Convert.ToInt32(reader.ReadLine());
				//
				Bark_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				Bark_Bar.Maximum = Convert.ToInt32(reader.ReadLine());
				//
				Wool_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				Wool_Bar.Maximum = Convert.ToInt32(reader.ReadLine());
				//
				GL_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				GL_Bar.Maximum = Convert.ToInt32(reader.ReadLine());
				//
				Food_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				Food_Bar.Maximum = Convert.ToInt32(reader.ReadLine());
				//
				Shard_Bar.Minimum = Convert.ToInt32(reader.ReadLine());
				Shard_Bar.Maximum = Convert.ToInt32(reader.ReadLine());

				reader.Close();
			}
		}

		private void DefaultBackup()
		{
			string filePath = Directory.GetCurrentDirectory();

			filePath += "\\prefs";

			Directory.CreateDirectory(filePath);

			filePath += "\\default.txt";

			if (!File.Exists(filePath))
			{
				StreamWriter writer = new StreamWriter(filePath);

				writer.WriteLine(WF_Bar.Minimum);
				writer.WriteLine(WF_Bar.Maximum);
				//
				writer.WriteLine(Ore_Bar.Minimum);
				writer.WriteLine(Ore_Bar.Maximum);
				//
				writer.WriteLine(Bark_Bar.Minimum);
				writer.WriteLine(Bark_Bar.Maximum);
				//
				writer.WriteLine(Wool_Bar.Minimum);
				writer.WriteLine(Wool_Bar.Maximum);
				//
				writer.WriteLine(GL_Bar.Minimum);
				writer.WriteLine(GL_Bar.Maximum);
				//
				writer.WriteLine(Food_Bar.Minimum);
				writer.WriteLine(Food_Bar.Maximum);
				//
				writer.WriteLine(Shard_Bar.Minimum);
				writer.WriteLine(Shard_Bar.Maximum);

				writer.Close();
			}


		}
	}
}
