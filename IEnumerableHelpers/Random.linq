<Query Kind="Expression" />

//Retrieve a random element from an ienumerable
public static class IEnumerableExtension
{ 
		private static Random randomizer { get; set; } = new Random();
	
		public static T Random<T>(this IEnumerable<T> enumerable)
		{
			return enumerable.OrderBy(x => randomizer.Next()).FirstOrDefault();
		}
}
