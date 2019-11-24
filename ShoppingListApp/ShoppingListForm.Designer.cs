namespace ShoppingListApp
{
	partial class ShoppingListForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lstShoppingItems = new System.Windows.Forms.ListBox();
			this.btnAddItems = new System.Windows.Forms.Button();
			this.btnChangeItems = new System.Windows.Forms.Button();
			this.btnDeleteItems = new System.Windows.Forms.Button();
			this.grpInputs = new System.Windows.Forms.GroupBox();
			this.btnClearInputs = new System.Windows.Forms.Button();
			this.unitTypeLabel = new System.Windows.Forms.Label();
			this.amountLabel = new System.Windows.Forms.Label();
			this.cboUnit = new System.Windows.Forms.ComboBox();
			this.spinAmount = new System.Windows.Forms.NumericUpDown();
			this.txtIngredient = new System.Windows.Forms.TextBox();
			this.ingredientLabel = new System.Windows.Forms.Label();
			this.btnPrintList = new System.Windows.Forms.Button();
			this.grpInputs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// lstShoppingItems
			// 
			this.lstShoppingItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstShoppingItems.ColumnWidth = 200;
			this.lstShoppingItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstShoppingItems.ItemHeight = 25;
			this.lstShoppingItems.Location = new System.Drawing.Point(12, 213);
			this.lstShoppingItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.lstShoppingItems.MultiColumn = true;
			this.lstShoppingItems.Name = "lstShoppingItems";
			this.lstShoppingItems.Size = new System.Drawing.Size(659, 129);
			this.lstShoppingItems.TabIndex = 8;
			this.lstShoppingItems.SelectedIndexChanged += new System.EventHandler(this.ingredientsListBox_SelectedIndexChanged);
			// 
			// btnAddItems
			// 
			this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddItems.Location = new System.Drawing.Point(380, 153);
			this.btnAddItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnAddItems.Name = "btnAddItems";
			this.btnAddItems.Size = new System.Drawing.Size(93, 26);
			this.btnAddItems.TabIndex = 5;
			this.btnAddItems.Text = "Add";
			this.btnAddItems.UseVisualStyleBackColor = true;
			this.btnAddItems.Click += new System.EventHandler(this.addItemButton_Click);
			// 
			// btnChangeItems
			// 
			this.btnChangeItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangeItems.Location = new System.Drawing.Point(483, 153);
			this.btnChangeItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnChangeItems.Name = "btnChangeItems";
			this.btnChangeItems.Size = new System.Drawing.Size(93, 26);
			this.btnChangeItems.TabIndex = 6;
			this.btnChangeItems.Text = "Change";
			this.btnChangeItems.UseVisualStyleBackColor = true;
			this.btnChangeItems.Click += new System.EventHandler(this.changeItemButton_Click);
			// 
			// btnDeleteItems
			// 
			this.btnDeleteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteItems.Location = new System.Drawing.Point(586, 153);
			this.btnDeleteItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnDeleteItems.Name = "btnDeleteItems";
			this.btnDeleteItems.Size = new System.Drawing.Size(93, 26);
			this.btnDeleteItems.TabIndex = 7;
			this.btnDeleteItems.Text = "Delete";
			this.btnDeleteItems.UseVisualStyleBackColor = true;
			this.btnDeleteItems.Click += new System.EventHandler(this.deleteItemButton_Click);
			// 
			// grpInputs
			// 
			this.grpInputs.Controls.Add(this.btnClearInputs);
			this.grpInputs.Controls.Add(this.unitTypeLabel);
			this.grpInputs.Controls.Add(this.amountLabel);
			this.grpInputs.Controls.Add(this.cboUnit);
			this.grpInputs.Controls.Add(this.spinAmount);
			this.grpInputs.Controls.Add(this.txtIngredient);
			this.grpInputs.Controls.Add(this.ingredientLabel);
			this.grpInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpInputs.Location = new System.Drawing.Point(12, 32);
			this.grpInputs.Name = "grpInputs";
			this.grpInputs.Size = new System.Drawing.Size(667, 116);
			this.grpInputs.TabIndex = 9;
			this.grpInputs.TabStop = false;
			this.grpInputs.Text = "List Items";
			// 
			// btnClearInputs
			// 
			this.btnClearInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearInputs.Location = new System.Drawing.Point(550, 59);
			this.btnClearInputs.Name = "btnClearInputs";
			this.btnClearInputs.Size = new System.Drawing.Size(93, 26);
			this.btnClearInputs.TabIndex = 4;
			this.btnClearInputs.Text = "Clear";
			this.btnClearInputs.UseVisualStyleBackColor = true;
			this.btnClearInputs.Click += new System.EventHandler(this.btnClearInputs_Click);
			// 
			// unitTypeLabel
			// 
			this.unitTypeLabel.AutoSize = true;
			this.unitTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unitTypeLabel.Location = new System.Drawing.Point(392, 36);
			this.unitTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.unitTypeLabel.Name = "unitTypeLabel";
			this.unitTypeLabel.Size = new System.Drawing.Size(89, 20);
			this.unitTypeLabel.TabIndex = 13;
			this.unitTypeLabel.Text = "Unit Type";
			// 
			// amountLabel
			// 
			this.amountLabel.AutoSize = true;
			this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.amountLabel.Location = new System.Drawing.Point(295, 36);
			this.amountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(72, 20);
			this.amountLabel.TabIndex = 12;
			this.amountLabel.Text = "Amount";
			// 
			// cboUnit
			// 
			this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboUnit.Location = new System.Drawing.Point(392, 57);
			this.cboUnit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.cboUnit.MaxDropDownItems = 20;
			this.cboUnit.Name = "cboUnit";
			this.cboUnit.Size = new System.Drawing.Size(137, 28);
			this.cboUnit.Sorted = true;
			this.cboUnit.TabIndex = 3;
			// 
			// spinAmount
			// 
			this.spinAmount.DecimalPlaces = 1;
			this.spinAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spinAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.spinAmount.Location = new System.Drawing.Point(295, 58);
			this.spinAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.spinAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.spinAmount.Name = "spinAmount";
			this.spinAmount.Size = new System.Drawing.Size(72, 27);
			this.spinAmount.TabIndex = 2;
			this.spinAmount.ThousandsSeparator = true;
			this.spinAmount.Enter += new System.EventHandler(this.amountNumberUpDown_Enter);
			// 
			// txtIngredient
			// 
			this.txtIngredient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtIngredient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIngredient.Location = new System.Drawing.Point(3, 59);
			this.txtIngredient.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txtIngredient.Name = "txtIngredient";
			this.txtIngredient.Size = new System.Drawing.Size(279, 26);
			this.txtIngredient.TabIndex = 1;
			this.txtIngredient.WordWrap = false;
			// 
			// ingredientLabel
			// 
			this.ingredientLabel.AutoSize = true;
			this.ingredientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ingredientLabel.Location = new System.Drawing.Point(3, 36);
			this.ingredientLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.ingredientLabel.Name = "ingredientLabel";
			this.ingredientLabel.Size = new System.Drawing.Size(146, 20);
			this.ingredientLabel.TabIndex = 9;
			this.ingredientLabel.Text = "Ingredient Name";
			// 
			// btnPrintList
			// 
			this.btnPrintList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrintList.Location = new System.Drawing.Point(578, 385);
			this.btnPrintList.Name = "btnPrintList";
			this.btnPrintList.Size = new System.Drawing.Size(93, 26);
			this.btnPrintList.TabIndex = 9;
			this.btnPrintList.Text = "Print";
			this.btnPrintList.UseVisualStyleBackColor = true;
			this.btnPrintList.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// ShoppingListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 433);
			this.Controls.Add(this.btnPrintList);
			this.Controls.Add(this.grpInputs);
			this.Controls.Add(this.btnDeleteItems);
			this.Controls.Add(this.btnChangeItems);
			this.Controls.Add(this.btnAddItems);
			this.Controls.Add(this.lstShoppingItems);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "ShoppingListForm";
			this.Text = "New Shopping List";
			this.Shown += new System.EventHandler(this.ShoppingListForm_Shown);
			this.grpInputs.ResumeLayout(false);
			this.grpInputs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinAmount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox lstShoppingItems;
		private System.Windows.Forms.Button btnAddItems;
		private System.Windows.Forms.Button btnChangeItems;
		private System.Windows.Forms.Button btnDeleteItems;
		private System.Windows.Forms.GroupBox grpInputs;
		private System.Windows.Forms.Label unitTypeLabel;
		private System.Windows.Forms.Label amountLabel;
		private System.Windows.Forms.ComboBox cboUnit;
		private System.Windows.Forms.NumericUpDown spinAmount;
		private System.Windows.Forms.TextBox txtIngredient;
		private System.Windows.Forms.Label ingredientLabel;
		private System.Windows.Forms.Button btnClearInputs;
		private System.Windows.Forms.Button btnPrintList;
	}
}