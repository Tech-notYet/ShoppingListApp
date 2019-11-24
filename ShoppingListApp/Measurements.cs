using System;

namespace ShoppingListApp
{
	public enum UnitType
	{
		item = 0, teaspoon, tablespoon, floz, cup, pint, quart, gallon, milliliter, liter,
		ounce, pound, milligram, gram, kilogram,
		small, medium, large
	};
	public static class Measurements
	{
		public static string UnitToString(UnitType u) => Enum.GetName(typeof(UnitType), u);
		public static string[] AllUnitsToString() => Enum.GetNames(typeof(UnitType));
	}

}