using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
	/// <summary>
	/// class ListManager()
	/// <para>This class is used to perform all the application logic.
	/// It creates a List of ShoppingItem objects
	/// and contains all the methods used to alter the list as necessary.</para>
	/// </summary>
	class ListManager
	{
		private readonly List<ShoppingItem> itemsList = new List<ShoppingItem>();
		public int Count => this.itemsList.Count;

		public ShoppingItem this[int index] { get => this.itemsList[index]; set => this.itemsList[index] = value; }

		/// <summary>
		/// Constructor for the ListManager class.
		/// </summary>
		public ListManager() {

		}

		public bool ValidIndex(int index) => (index >= 0) && (index < this.itemsList.Count);

		public void AddShoppingItem(ShoppingItem itemToAdd) {
			if (this.itemsList.Contains(itemToAdd)) {
				MergeShoppingItem(itemToAdd, index);
			} else {
				this.itemsList.Add(itemToAdd);
			}
		}

		public void RemoveShoppingItem(int indexOfItem) {
			if (ValidIndex(indexOfItem)) {
				this.itemsList.RemoveAt(indexOfItem);
			}
		}
		/// <summary>
		/// Method to update an the itemsList field by supplying
		/// a new <see cref="ShoppingItem"/> object and the <paramref name="index"/> of the ShoppingItem to
		/// be changed.
		/// </summary>
		/// <param name="updatedItem">ShoppingItem object with updated properties</param>
		/// <param name="index">index of the itemsList[index] instance</param>
		public void ChangeShoppingItem(ShoppingItem updatedItem, int index) {
			if (ValidIndex(index)) {
				this[index].Ingredient = updatedItem.Ingredient;
				this[index].Amount = updatedItem.Amount;
				this[index].Unit = updatedItem.Unit;
			}
		}

		public void MergeShoppingItem(ShoppingItem item, int index) {
			if (ValidIndex(index)) {
				this[index].Amount += item.Amount;
			}
		}
	}
}
