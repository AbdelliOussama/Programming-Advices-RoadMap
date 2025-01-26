partial class Program
{
	static void Main5()
	{
		List<string> urls = new()
		{
			"https://www.google.com",
			"https://www.programmingAdvices.com",
			"https://www.Facebook.com"
		};

		Parallel.ForEach(urls, url => downloadWebSite(url));
	}

	static void downloadWebSite(string url) => Console.WriteLine($"downloaded {url}");
}
