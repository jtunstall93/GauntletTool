namespace GauntletTool
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.okayButton = new System.Windows.Forms.Button();
			this.valuesLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// okayButton
			// 
			this.okayButton.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.okayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okayButton.ForeColor = System.Drawing.SystemColors.Window;
			this.okayButton.Location = new System.Drawing.Point(57, 57);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(100, 34);
			this.okayButton.TabIndex = 29;
			this.okayButton.Text = "Okay";
			this.okayButton.UseVisualStyleBackColor = false;
			this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
			// 
			// valuesLabel
			// 
			this.valuesLabel.AutoSize = true;
			this.valuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.valuesLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.valuesLabel.Location = new System.Drawing.Point(53, 19);
			this.valuesLabel.Name = "valuesLabel";
			this.valuesLabel.Size = new System.Drawing.Size(107, 20);
			this.valuesLabel.TabIndex = 30;
			this.valuesLabel.Text = "Invalid Values";
			this.valuesLabel.Click += new System.EventHandler(this.valuesLabel_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(208, 112);
			this.Controls.Add(this.valuesLabel);
			this.Controls.Add(this.okayButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Gauntlet Tool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.Label valuesLabel;
	}
}