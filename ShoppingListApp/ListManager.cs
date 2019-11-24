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
	class ListManager:IList<ShoppingItem>
	{
		private List<ShoppingItem> shoppingItems = new List<ShoppingItem>();
		public int Count => this.shoppingItems.Count;
		public bool IsReadOnly { get; }

		public ShoppingItem this[int index] { get => this.shoppingItems[index]; set => this.shoppingItems[index] = value; }

		/// <summary>
		/// Constructor for the ListManager class.
		/// </summary>
		public ListManager(bool readOnly = false) {
			this.IsReadOnly = readOnly;
		}

		/// <summary>
		/// Counts the number of elements in the shoppingItems List.
		/// </summary>
		public int CountItems() => this.Count;

		public bool ValidIndex(int index) => (index >= 0) && (index < this.Count);

		public void AddShoppingItem(ShoppingItem itemToAdd) {
			if (IngredientInList(itemToAdd, out int index)) {
				MergeShoppingItem(itemToAdd, index);
			} else {
				this.shoppingItems.Add(itemToAdd);
			}
		}

		public void RemoveShoppingItem(int indexOfItem) {
			if (ValidIndex(indexOfItem)) {
				this.shoppingItems.RemoveAt(indexOfItem);
			}
		}
		/// <summary>
		/// Method to update an existing <see cref="shoppingItems"/> instance by supplying
		/// a new <see cref="ShoppingItem"/> object and the index of the ShoppingItem to
		/// be changed.
		/// </summary>
		/// <param name="updatedItem">ShoppingItem object with updated properties</param>
		/// <param name="indexOfItemToChange">index of the shoppingItems[index] instance</param>
		public void ChangeShoppingItem(ShoppingItem updatedItem, int indexOfItemToChange) {
			if (ValidIndex(indexOfItemToChange)) {
				this[indexOfItemToChange].Ingredient = updatedItem.Ingredient;
				this[indexOfItemToChange].Amount = updatedItem.Amount;
				this[indexOfItemToChange].Unit = updatedItem.Unit;
			}
		}

		public bool IngredientInList(ShoppingItem item, out int index) {
			if (this.Contains(item)) {
				index = this.IndexOf(item);
				return true;
			}
			index = -1;
			return false;
		}

		public void MergeShoppingItem(ShoppingItem item, int index) => this[index].Amount += item.Amount;
		public int IndexOf(ShoppingItem item) {
			for (int i = 0; i < this.Count; i++) {
				if (this[i].Equals(item)) {
					return i;
				}
			}
			return -1;
		}
		public void Insert(int index, ShoppingItem item) => throw new NotImplementedException();
		public void RemoveAt(int index) => throw new NotImplementedException();
		public void Add(ShoppingItem item) => throw new NotImplementedException();
		public void Clear() => throw new NotImplementedException();
		public bool Contains(ShoppingItem item) {
			foreach (ShoppingItem shopping in this) {
				if (shopping.Equals(item)) {
					return true;
				}
			}
			return false;
		}
		public void CopyTo(ShoppingItem[] array, int arrayIndex) => throw new NotImplementedException();
		public bool Remove(ShoppingItem item) => throw new NotImplementedException();
		public IEnumerator<ShoppingItem> GetEnumerator() => throw new NotImplementedException();
		IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
	}
}
