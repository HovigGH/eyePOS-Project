namespace MultiFaceRec{
	partial class CustForm1
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
			this.callhelpButton = new System.Windows.Forms.Button();
			this.totalBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cartGrid = new System.Windows.Forms.DataGridView();
			this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
			this.qtyCol = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
			this.codeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barcodeInputTextbox = new System.Windows.Forms.TextBox();
			this.dataGridViewNumericUpDownColumn1 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.checkOutButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.subtotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// callhelpButton
			// 
			this.callhelpButton.Location = new System.Drawing.Point(12, 570);
			this.callhelpButton.Name = "callhelpButton";
			this.callhelpButton.Size = new System.Drawing.Size(121, 72);
			this.callhelpButton.TabIndex = 3;
			this.callhelpButton.Text = "Call for Assistance";
			this.callhelpButton.UseVisualStyleBackColor = true;
			// 
			// totalBox
			// 
			this.totalBox.Location = new System.Drawing.Point(3, 52);
			this.totalBox.Name = "totalBox";
			this.totalBox.Size = new System.Drawing.Size(394, 72);
			this.totalBox.TabIndex = 6;
			this.totalBox.Text = "Total: 1 dolla";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 295);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 18);
			this.label1.TabIndex = 8;
			this.label1.Text = "Please Scan Your Item Now";
			// 
			// cartGrid
			// 
			this.cartGrid.AllowUserToAddRows = false;
			this.cartGrid.AllowUserToDeleteRows = false;
			this.cartGrid.AllowUserToResizeColumns = false;
			this.cartGrid.AllowUserToResizeRows = false;
			this.cartGrid.BackgroundColor = System.Drawing.Color.White;
			this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCol,
            this.qtyCol,
            this.codeCol,
            this.itemCol,
            this.priceCol});
			this.cartGrid.Location = new System.Drawing.Point(403, 12);
			this.cartGrid.Name = "cartGrid";
			this.cartGrid.RowHeadersVisible = false;
			this.cartGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.cartGrid.Size = new System.Drawing.Size(653, 552);
			this.cartGrid.TabIndex = 10;
			this.cartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGrid_CellContentClick);
			this.cartGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGrid_CellValueChanged);
			// 
			// deleteCol
			// 
			this.deleteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.deleteCol.HeaderText = "🗑️";
			this.deleteCol.Name = "deleteCol";
			this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.deleteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.deleteCol.Width = 30;
			// 
			// qtyCol
			// 
			this.qtyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.qtyCol.HeaderText = "Qty";
			this.qtyCol.Name = "qtyCol";
			this.qtyCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.qtyCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.qtyCol.Width = 48;
			// 
			// codeCol
			// 
			this.codeCol.HeaderText = "UPC";
			this.codeCol.Name = "codeCol";
			this.codeCol.ReadOnly = true;
			// 
			// itemCol
			// 
			this.itemCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.itemCol.HeaderText = "Item Name";
			this.itemCol.Name = "itemCol";
			this.itemCol.ReadOnly = true;
			this.itemCol.Width = 400;
			// 
			// priceCol
			// 
			this.priceCol.HeaderText = "Price";
			this.priceCol.Name = "priceCol";
			this.priceCol.ReadOnly = true;
			this.priceCol.Width = 200;
			// 
			// barcodeInputTextbox
			// 
			this.barcodeInputTextbox.Location = new System.Drawing.Point(80, 316);
			this.barcodeInputTextbox.Name = "barcodeInputTextbox";
			this.barcodeInputTextbox.Size = new System.Drawing.Size(223, 20);
			this.barcodeInputTextbox.TabIndex = 12;
			this.barcodeInputTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeInputTextbox_KeyDown);
			// 
			// dataGridViewNumericUpDownColumn1
			// 
			this.dataGridViewNumericUpDownColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewNumericUpDownColumn1.HeaderText = "Qty";
			this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
			this.dataGridViewNumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewNumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "UPC";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 400;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Price";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 200;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(135, 339);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "(or enter a UPC)";
			// 
			// checkOutButton
			// 
			this.checkOutButton.Location = new System.Drawing.Point(276, 570);
			this.checkOutButton.Name = "checkOutButton";
			this.checkOutButton.Size = new System.Drawing.Size(121, 72);
			this.checkOutButton.TabIndex = 14;
			this.checkOutButton.Text = "Check Out";
			this.checkOutButton.UseVisualStyleBackColor = true;
			this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subtotalCol,
            this.taxCol,
            this.totalCol});
			this.dataGridView1.Location = new System.Drawing.Point(403, 570);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(653, 72);
			this.dataGridView1.TabIndex = 15;
			// 
			// subtotalCol
			// 
			this.subtotalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.subtotalCol.Frozen = true;
			this.subtotalCol.HeaderText = "Subtotal";
			this.subtotalCol.Name = "subtotalCol";
			this.subtotalCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.subtotalCol.Width = 200;
			// 
			// taxCol
			// 
			this.taxCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.taxCol.HeaderText = "Tax @ 15%";
			this.taxCol.Name = "taxCol";
			this.taxCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.taxCol.Width = 200;
			// 
			// totalCol
			// 
			this.totalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.totalCol.HeaderText = "Total";
			this.totalCol.Name = "totalCol";
			this.totalCol.ReadOnly = true;
			this.totalCol.Width = 200;
			// 
			// CustForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 651);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.checkOutButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.barcodeInputTextbox);
			this.Controls.Add(this.cartGrid);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.totalBox);
			this.Controls.Add(this.callhelpButton);
			this.Name = "CustForm1";
			this.Text = "CustForm1";
			this.Load += new System.EventHandler(this.CustForm1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustForm1_KeyDown_1);
			((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button callhelpButton;
		private System.Windows.Forms.RichTextBox totalBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView cartGrid;
		private System.Windows.Forms.TextBox barcodeInputTextbox;
		private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
		private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn qtyCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn codeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button checkOutButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn subtotalCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn taxCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
	}
}