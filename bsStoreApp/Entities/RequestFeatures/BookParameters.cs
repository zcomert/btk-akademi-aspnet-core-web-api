namespace Entities.RequestFeatures
{
    public class BookParameters : RequestParameters
	{
		public uint MinPrice { get; set; }
		public uint MaxPrice { get; set; } = 1000;
		public bool ValidPriceRange => MaxPrice > MinPrice;

		public String? SearchTerm { get; set; }

		public BookParameters()
		{
			OrderBy = "id";
		}
	}
}
