namespace GauntletTool
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Gear_Box = new System.Windows.Forms.CheckedListBox();
			this.WF_Count = new System.Windows.Forms.NumericUpDown();
			this.Ore_Count = new System.Windows.Forms.NumericUpDown();
			this.Bark_Count = new System.Windows.Forms.NumericUpDown();
			this.Wool_Count = new System.Windows.Forms.NumericUpDown();
			this.GL_Count = new System.Windows.Forms.NumericUpDown();
			this.Food_Count = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.T3_Wep_Attachment = new System.Windows.Forms.CheckedListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Shard_Count = new System.Windows.Forms.NumericUpDown();
			this.WF_Bar = new System.Windows.Forms.ProgressBar();
			this.Ore_Bar = new System.Windows.Forms.ProgressBar();
			this.Bark_Bar = new System.Windows.Forms.ProgressBar();
			this.Wool_Bar = new System.Windows.Forms.ProgressBar();
			this.GL_Bar = new System.Windows.Forms.ProgressBar();
			this.Food_Bar = new System.Windows.Forms.ProgressBar();
			this.Shard_Bar = new System.Windows.Forms.ProgressBar();
			this.label8 = new System.Windows.Forms.Label();
			this.ResetButton = new System.Windows.Forms.Button();
			this.customBoundsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.WF_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ore_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Bark_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Wool_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GL_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Food_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Shard_Count)).BeginInit();
			this.SuspendLayout();
			// 
			// Gear_Box
			// 
			this.Gear_Box.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.Gear_Box.ForeColor = System.Drawing.SystemColors.Window;
			this.Gear_Box.FormattingEnabled = true;
			this.Gear_Box.Items.AddRange(new object[] {
            "Weapon 1",
            "Weapon 2",
            "Chest",
            "Legs",
            "Helm",
            "Food",
            "Eggnog"});
			this.Gear_Box.Location = new System.Drawing.Point(13, 195);
			this.Gear_Box.Name = "Gear_Box";
			this.Gear_Box.Size = new System.Drawing.Size(101, 109);
			this.Gear_Box.TabIndex = 0;
			this.Gear_Box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Gear_Box_ItemCheck);
			// 
			// WF_Count
			// 
			this.WF_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.WF_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.WF_Count.Location = new System.Drawing.Point(13, 13);
			this.WF_Count.Name = "WF_Count";
			this.WF_Count.Size = new System.Drawing.Size(120, 20);
			this.WF_Count.TabIndex = 1;
			this.WF_Count.ValueChanged += new System.EventHandler(this.WF_Count_ValueChanged);
			// 
			// Ore_Count
			// 
			this.Ore_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.Ore_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.Ore_Count.Location = new System.Drawing.Point(12, 39);
			this.Ore_Count.Name = "Ore_Count";
			this.Ore_Count.Size = new System.Drawing.Size(120, 20);
			this.Ore_Count.TabIndex = 2;
			this.Ore_Count.ValueChanged += new System.EventHandler(this.Ore_Count_ValueChanged);
			// 
			// Bark_Count
			// 
			this.Bark_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.Bark_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.Bark_Count.Location = new System.Drawing.Point(13, 65);
			this.Bark_Count.Name = "Bark_Count";
			this.Bark_Count.Size = new System.Drawing.Size(120, 20);
			this.Bark_Count.TabIndex = 3;
			this.Bark_Count.ValueChanged += new System.EventHandler(this.Bark_Count_ValueChanged);
			// 
			// Wool_Count
			// 
			this.Wool_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.Wool_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.Wool_Count.Location = new System.Drawing.Point(12, 91);
			this.Wool_Count.Name = "Wool_Count";
			this.Wool_Count.Size = new System.Drawing.Size(120, 20);
			this.Wool_Count.TabIndex = 4;
			this.Wool_Count.ValueChanged += new System.EventHandler(this.Wool_Count_ValueChanged);
			// 
			// GL_Count
			// 
			this.GL_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.GL_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.GL_Count.Location = new System.Drawing.Point(12, 117);
			this.GL_Count.Name = "GL_Count";
			this.GL_Count.Size = new System.Drawing.Size(120, 20);
			this.GL_Count.TabIndex = 5;
			this.GL_Count.ValueChanged += new System.EventHandler(this.GL_Count_ValueChanged);
			// 
			// Food_Count
			// 
			this.Food_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.Food_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.Food_Count.Location = new System.Drawing.Point(13, 143);
			this.Food_Count.Name = "Food_Count";
			this.Food_Count.Size = new System.Drawing.Size(120, 20);
			this.Food_Count.TabIndex = 6;
			this.Food_Count.ValueChanged += new System.EventHandler(this.Food_Count_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(139, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Weapon Frames";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(139, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Ore";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(139, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Bark";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(139, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Wool";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.Window;
			this.label5.Location = new System.Drawing.Point(139, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Grym Leaves";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.Window;
			this.label6.Location = new System.Drawing.Point(139, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Food";
			// 
			// T3_Wep_Attachment
			// 
			this.T3_Wep_Attachment.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.T3_Wep_Attachment.ForeColor = System.Drawing.SystemColors.Window;
			this.T3_Wep_Attachment.FormattingEnabled = true;
			this.T3_Wep_Attachment.Items.AddRange(new object[] {
            "Orb (Staff)",
            "Spike (Halberd)",
            "Bowstring (Bow)"});
			this.T3_Wep_Attachment.Location = new System.Drawing.Point(120, 195);
			this.T3_Wep_Attachment.Name = "T3_Wep_Attachment";
			this.T3_Wep_Attachment.Size = new System.Drawing.Size(104, 49);
			this.T3_Wep_Attachment.TabIndex = 14;
			this.T3_Wep_Attachment.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.T3_Wep_Attachment_ItemCheck);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.Window;
			this.label7.Location = new System.Drawing.Point(138, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Shards";
			// 
			// Shard_Count
			// 
			this.Shard_Count.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.Shard_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.Shard_Count.Location = new System.Drawing.Point(12, 169);
			this.Shard_Count.Maximum = new decimal(new int[] {
            560,
            0,
            0,
            0});
			this.Shard_Count.Name = "Shard_Count";
			this.Shard_Count.Size = new System.Drawing.Size(120, 20);
			this.Shard_Count.TabIndex = 15;
			this.Shard_Count.ValueChanged += new System.EventHandler(this.Shard_Count_ValueChanged);
			// 
			// WF_Bar
			// 
			this.WF_Bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.WF_Bar.Location = new System.Drawing.Point(230, 13);
			this.WF_Bar.Maximum = 2;
			this.WF_Bar.Name = "WF_Bar";
			this.WF_Bar.Size = new System.Drawing.Size(100, 23);
			this.WF_Bar.TabIndex = 17;
			// 
			// Ore_Bar
			// 
			this.Ore_Bar.Location = new System.Drawing.Point(230, 39);
			this.Ore_Bar.Maximum = 10;
			this.Ore_Bar.Name = "Ore_Bar";
			this.Ore_Bar.Size = new System.Drawing.Size(100, 23);
			this.Ore_Bar.TabIndex = 18;
			// 
			// Bark_Bar
			// 
			this.Bark_Bar.Location = new System.Drawing.Point(230, 65);
			this.Bark_Bar.Maximum = 10;
			this.Bark_Bar.Name = "Bark_Bar";
			this.Bark_Bar.Size = new System.Drawing.Size(100, 23);
			this.Bark_Bar.TabIndex = 19;
			// 
			// Wool_Bar
			// 
			this.Wool_Bar.Location = new System.Drawing.Point(230, 91);
			this.Wool_Bar.Maximum = 10;
			this.Wool_Bar.Name = "Wool_Bar";
			this.Wool_Bar.Size = new System.Drawing.Size(100, 23);
			this.Wool_Bar.TabIndex = 20;
			// 
			// GL_Bar
			// 
			this.GL_Bar.Location = new System.Drawing.Point(230, 117);
			this.GL_Bar.Maximum = 3;
			this.GL_Bar.Name = "GL_Bar";
			this.GL_Bar.Size = new System.Drawing.Size(100, 23);
			this.GL_Bar.TabIndex = 21;
			// 
			// Food_Bar
			// 
			this.Food_Bar.Location = new System.Drawing.Point(230, 143);
			this.Food_Bar.Maximum = 18;
			this.Food_Bar.Name = "Food_Bar";
			this.Food_Bar.Size = new System.Drawing.Size(100, 23);
			this.Food_Bar.TabIndex = 22;
			// 
			// Shard_Bar
			// 
			this.Shard_Bar.Location = new System.Drawing.Point(230, 169);
			this.Shard_Bar.Maximum = 560;
			this.Shard_Bar.Name = "Shard_Bar";
			this.Shard_Bar.Size = new System.Drawing.Size(100, 23);
			this.Shard_Bar.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Aqua;
			this.label8.Location = new System.Drawing.Point(113, 253);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 37);
			this.label8.TabIndex = 24;
			this.label8.Text = "Ready!";
			this.label8.Visible = false;
			// 
			// ResetButton
			// 
			this.ResetButton.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResetButton.ForeColor = System.Drawing.SystemColors.Window;
			this.ResetButton.Location = new System.Drawing.Point(230, 256);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(100, 34);
			this.ResetButton.TabIndex = 25;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = false;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// customBoundsButton
			// 
			this.customBoundsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.customBoundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customBoundsButton.ForeColor = System.Drawing.SystemColors.Window;
			this.customBoundsButton.Location = new System.Drawing.Point(230, 210);
			this.customBoundsButton.Name = "customBoundsButton";
			this.customBoundsButton.Size = new System.Drawing.Size(100, 34);
			this.customBoundsButton.TabIndex = 26;
			this.customBoundsButton.Text = "Custom Bounds";
			this.customBoundsButton.UseVisualStyleBackColor = false;
			this.customBoundsButton.Click += new System.EventHandler(this.customBoundsButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(345, 311);
			this.Controls.Add(this.customBoundsButton);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Shard_Bar);
			this.Controls.Add(this.Food_Bar);
			this.Controls.Add(this.GL_Bar);
			this.Controls.Add(this.Wool_Bar);
			this.Controls.Add(this.Bark_Bar);
			this.Controls.Add(this.Ore_Bar);
			this.Controls.Add(this.WF_Bar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Shard_Count);
			this.Controls.Add(this.T3_Wep_Attachment);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Food_Count);
			this.Controls.Add(this.GL_Count);
			this.Controls.Add(this.Wool_Count);
			this.Controls.Add(this.Bark_Count);
			this.Controls.Add(this.Ore_Count);
			this.Controls.Add(this.WF_Count);
			this.Controls.Add(this.Gear_Box);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Gauntlet Tool";
			((System.ComponentModel.ISupportInitialize)(this.WF_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ore_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Bark_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Wool_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GL_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Food_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Shard_Count)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox Gear_Box;
		private System.Windows.Forms.NumericUpDown WF_Count;
		private System.Windows.Forms.NumericUpDown Ore_Count;
		private System.Windows.Forms.NumericUpDown Bark_Count;
		private System.Windows.Forms.NumericUpDown Wool_Count;
		private System.Windows.Forms.NumericUpDown GL_Count;
		private System.Windows.Forms.NumericUpDown Food_Count;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckedListBox T3_Wep_Attachment;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown Shard_Count;
		private System.Windows.Forms.ProgressBar WF_Bar;
		private System.Windows.Forms.ProgressBar Ore_Bar;
		private System.Windows.Forms.ProgressBar Bark_Bar;
		private System.Windows.Forms.ProgressBar Wool_Bar;
		private System.Windows.Forms.ProgressBar GL_Bar;
		private System.Windows.Forms.ProgressBar Food_Bar;
		private System.Windows.Forms.ProgressBar Shard_Bar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button customBoundsButton;
	}
}

