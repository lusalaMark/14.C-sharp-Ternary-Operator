namespace _14.C_sharp_Ternary_Operator
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
			this.lblFinalAmount = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblAmountFormatted = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblFinalAmount
			// 
			this.lblFinalAmount.AutoSize = true;
			this.lblFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.lblFinalAmount.Location = new System.Drawing.Point(24, 329);
			this.lblFinalAmount.Name = "lblFinalAmount";
			this.lblFinalAmount.Size = new System.Drawing.Size(0, 63);
			this.lblFinalAmount.TabIndex = 9;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Decrease by 10% (multiply values by 0.9) (index is 0, not 1)",
            "Increase by 10% (multiply value by 1.1) (index is 1, not 2)"});
			this.comboBox1.Location = new System.Drawing.Point(47, 211);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(1137, 69);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// lblAmountFormatted
			// 
			this.lblAmountFormatted.AutoSize = true;
			this.lblAmountFormatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.lblAmountFormatted.Location = new System.Drawing.Point(12, 98);
			this.lblAmountFormatted.Name = "lblAmountFormatted";
			this.lblAmountFormatted.Size = new System.Drawing.Size(0, 63);
			this.lblAmountFormatted.TabIndex = 7;
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.txtAmount.Location = new System.Drawing.Point(375, 9);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(555, 68);
			this.txtAmount.TabIndex = 6;
			this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(371, 63);
			this.label1.TabIndex = 5;
			this.label1.Text = "Enter Amount:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1235, 533);
			this.Controls.Add(this.lblFinalAmount);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblAmountFormatted);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFinalAmount;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblAmountFormatted;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label label1;
	}
}

