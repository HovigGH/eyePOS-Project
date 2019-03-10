namespace MultiFaceRec
{
	partial class EmpForm1
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
			this.invGV = new System.Windows.Forms.DataGridView();
			this.nameSearchButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.upcSearchButton = new System.Windows.Forms.Button();
			this.searchGB = new System.Windows.Forms.GroupBox();
			this.addInvButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.refreshInvButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.invGV)).BeginInit();
			this.searchGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// invGV
			// 
			this.invGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.invGV.Location = new System.Drawing.Point(12, 12);
			this.invGV.Name = "invGV";
			this.invGV.Size = new System.Drawing.Size(469, 479);
			this.invGV.TabIndex = 0;
			// 
			// nameSearchButton
			// 
			this.nameSearchButton.Location = new System.Drawing.Point(235, 19);
			this.nameSearchButton.Name = "nameSearchButton";
			this.nameSearchButton.Size = new System.Drawing.Size(115, 86);
			this.nameSearchButton.TabIndex = 1;
			this.nameSearchButton.Text = "Search by Product Name";
			this.nameSearchButton.UseVisualStyleBackColor = true;
			this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 111);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(344, 20);
			this.textBox1.TabIndex = 3;
			// 
			// upcSearchButton
			// 
			this.upcSearchButton.Location = new System.Drawing.Point(6, 19);
			this.upcSearchButton.Name = "upcSearchButton";
			this.upcSearchButton.Size = new System.Drawing.Size(115, 86);
			this.upcSearchButton.TabIndex = 4;
			this.upcSearchButton.Text = "Search by UPC";
			this.upcSearchButton.UseVisualStyleBackColor = true;
			this.upcSearchButton.Click += new System.EventHandler(this.upcSearchButton_Click);
			// 
			// searchGB
			// 
			this.searchGB.Controls.Add(this.upcSearchButton);
			this.searchGB.Controls.Add(this.textBox1);
			this.searchGB.Controls.Add(this.nameSearchButton);
			this.searchGB.Location = new System.Drawing.Point(487, 12);
			this.searchGB.Name = "searchGB";
			this.searchGB.Size = new System.Drawing.Size(356, 138);
			this.searchGB.TabIndex = 6;
			this.searchGB.TabStop = false;
			this.searchGB.Text = "Search for Product";
			// 
			// addInvButton
			// 
			this.addInvButton.Location = new System.Drawing.Point(487, 149);
			this.addInvButton.Name = "addInvButton";
			this.addInvButton.Size = new System.Drawing.Size(82, 64);
			this.addInvButton.TabIndex = 7;
			this.addInvButton.Text = "Add to Stock";
			this.addInvButton.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(761, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 64);
			this.button1.TabIndex = 9;
			this.button1.Text = "Refund";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// refreshInvButton
			// 
			this.refreshInvButton.Location = new System.Drawing.Point(487, 427);
			this.refreshInvButton.Name = "refreshInvButton";
			this.refreshInvButton.Size = new System.Drawing.Size(82, 64);
			this.refreshInvButton.TabIndex = 10;
			this.refreshInvButton.Text = "Refresh";
			this.refreshInvButton.UseVisualStyleBackColor = true;
			this.refreshInvButton.Click += new System.EventHandler(this.refreshInvButton_Click);
			// 
			// EmpForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 651);
			this.Controls.Add(this.refreshInvButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.addInvButton);
			this.Controls.Add(this.searchGB);
			this.Controls.Add(this.invGV);
			this.Name = "EmpForm1";
			this.Text = "EmpForm1";
			this.Load += new System.EventHandler(this.EmpForm1_Load);
			((System.ComponentModel.ISupportInitialize)(this.invGV)).EndInit();
			this.searchGB.ResumeLayout(false);
			this.searchGB.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView invGV;
		private System.Windows.Forms.Button nameSearchButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button upcSearchButton;
		private System.Windows.Forms.GroupBox searchGB;
		private System.Windows.Forms.Button addInvButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button refreshInvButton;
	}
}