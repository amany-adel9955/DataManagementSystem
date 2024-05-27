namespace BlazorDataManagement.Models
{
	public class CitiesRepo
	{
		private static List<string> cities = new List<string>()
		{
			"c1",
			"c2",
			"c3",
			"c4"
		};

		public static List<string> GetAllCities() => cities;

	}
}
