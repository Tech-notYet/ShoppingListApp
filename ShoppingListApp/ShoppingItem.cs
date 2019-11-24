using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
	public class ShoppingItem
	{
		private string ingredient;
		private double amount;
		private UnitType unit;

		public string Ingredient
		{
			get => this.ingredient;
			set => this.ingredient = value ?? string.Empty;
		}
		public double Amount
		{
			get => amount;
			set => this.amount = value is double testValue ? testValue : 0.0;
		}
		public UnitType Unit
		{
			get => this.unit;
			set {
				if (Enum.IsDefined(typeof(UnitType), value)) {
					this.unit = value;
				} else {
					this.unit = UnitType.item;
				}
			}
		}

		public ShoppingItem() {
			this.ingredient = string.Empty;
			this.amount = 0.0;
			this.unit = UnitType.item;
		}
		public ShoppingItem(string ingredient) {
			this.ingredient = ingredient;
			this.amount = 0.0;
			this.unit = UnitType.item;
		}
		public ShoppingItem(string ingredient, decimal amt) {
			this.ingredient = ingredient;
			this.amount = (double)amt;
			this.unit = UnitType.item;
		}
		public ShoppingItem(string ingredient, decimal amount, UnitType u) {
			this.ingredient = ingredient;
			this.amount = (double)amount;
			this.unit = u;
		}

		public static bool operator ==(ShoppingItem firstItem, ShoppingItem secondItem) => firstItem.Equals(secondItem);

		public static bool operator !=(ShoppingItem a, ShoppingItem b) => !a.Equals(b);

		public override bool Equals(object obj) => obj is ShoppingItem item ? string.Equals(this.Ingredient, item.Ingredient, StringComparison.OrdinalIgnoreCase) : false;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() {
			return string.Format("{0,-20}\t{1,10:N1}\t{2,-20}", Ingredient, Amount, Enum.GetName(typeof(UnitType), Unit));
		}
	}
}
