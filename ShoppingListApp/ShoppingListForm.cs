using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
	public partial class ShoppingListForm: Form
	{
		private ListManager listManager = new ListManager();
		private AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
		public ShoppingListForm() {
			InitializeComponent();
			InitializeShoppingForm();
		}

		private void InitializeShoppingForm() {
			string[] values = Measurements.AllUnitsToString();
			cboUnit.Items.AddRange(values);
			txtIngredient.AutoCompleteCustomSource = autoComplete;
		}

		private UnitType GetUnitFromComboBox() => (UnitType)Enum.Parse(typeof(UnitType), (string)cboUnit.SelectedItem);

		private void changeItemButton_Click(object sender, EventArgs e) {
			if (FormFieldsCompleted()) {
				ShoppingItem s = new ShoppingItem(txtIngredient.Text, spinAmount.Value, GetUnitFromComboBox());
				listManager.ChangeShoppingItem(s, lstShoppingItems.SelectedIndex);
				ClearAllInputs();
				UpdateIngredientsList();
			}
		}
		private void addItemButton_Click(object sender, EventArgs e) {
			if (FormFieldsCompleted()) {
				ShoppingItem s = new ShoppingItem(txtIngredient.Text, spinAmount.Value, GetUnitFromComboBox());
				listManager.AddShoppingItem(s);
				autoComplete.Add(s.Ingredient);
				ClearAllInputs();
				UpdateIngredientsList();
			}
		}

		private void deleteItemButton_Click(object sender, EventArgs e) {
			if (lstShoppingItems.SelectedIndex != -1) {
				listManager.RemoveShoppingItem(lstShoppingItems.SelectedIndex);
			} else {
				GetMessage("An item must be selected before deleting.", "No Item Selected", icon: MessageBoxIcon.Error);
			}
			ClearAllInputs();
			UpdateIngredientsList();
		}

		public bool FormFieldsCompleted() {
			if (txtIngredient.TextLength == 0) {
				GetMessage("The ingredient textbox must be filled out.", "Missing Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtIngredient.Focus();
				return false;
			} else if (spinAmount.Value == 0.0M) {
				GetMessage("The amount must be greater than 0.", "Missing Amount", icon: MessageBoxIcon.Error);
				spinAmount.Focus();
				return false;
			} else if (cboUnit.SelectedIndex == -1) {
				GetMessage("A unit must be selected.", "Missing Unit", icon: MessageBoxIcon.Error);
				cboUnit.Focus();
				return false;
			} else {
				return true;
			}
		}

		private DialogResult GetMessage(string message, string caption = default, MessageBoxButtons buttons = default, MessageBoxIcon icon = default) => MessageBox.Show(message, caption, buttons, icon);

		public void UpdateIngredientsList() {
			lstShoppingItems.Items.Clear();
			for (int i = 0; i < listManager.CountItems(); i++) {
				lstShoppingItems.Items.Add(listManager.itemsList[i]);
			}
		}

		private void ingredientsListBox_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				ShoppingItem item = listManager.itemsList[lstShoppingItems.SelectedIndex];
				txtIngredient.Text = item.Ingredient;
				spinAmount.Value = (decimal)item.Amount;
				cboUnit.SelectedIndex = cboUnit.Items.IndexOf(Measurements.UnitToString(item.Unit));
			} catch (ArgumentOutOfRangeException) {
				return;
			}
		}

		private void ClearAllInputs() {
			txtIngredient.Text = string.Empty;
			spinAmount.Value = 0.0M;
			cboUnit.SelectedIndex = -1;
			txtIngredient.Focus();
		}

		private void btnClearInputs_Click(object sender, EventArgs e) => ClearAllInputs();

		private void btnPrint_Click(object sender, EventArgs e) => PrintShoppingList();

		private void PrintShoppingList() {
			PrintDocument doc = new PrintDocument();
			doc.DocumentName = string.Format($"Shopping List - {0}", new DateTime().ToLongDateString());
			doc.PrintPage += doc_PrintPage;

			PrintPreviewDialog printPreview = new PrintPreviewDialog();
			printPreview.Document = doc;

			if (printPreview.ShowDialog() == DialogResult.OK) {
				doc.Print();
			}
		}

		private void doc_PrintPage(object sender, PrintPageEventArgs e) {
			float y = 100;
			string title = string.Format("Shopping List - {0}", DateTime.Today);
			Font font = new Font(FontFamily.GenericSansSerif, 12);
			Brush black = Brushes.Black;
			e.Graphics.DrawString(title, font, black, 100, y);
			for (int i = 0; i < lstShoppingItems.Items.Count; i++) {
				y += 50;
				e.Graphics.DrawString(this.lstShoppingItems.Items[i].ToString(), font, black, 100, y);
			}
		}

		private void amountNumberUpDown_Enter(object sender, EventArgs e) {
			string amountValue = $"{spinAmount.Value:F}";
			spinAmount.Select(0, amountValue.Length);
		}

		private void ShoppingListForm_Shown(object sender, EventArgs e) {
			txtIngredient.Focus();
		}
	}
}
