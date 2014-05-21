using CalameoDownloader.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CalameoDownloader
{
	static class BookInfoRetriever
	{
		const string UrlPattern = "http://d.calameo.com/3.0.0/book.php?bkcode={0}";

		public static RootObject GetInfo(string bookCode)
		{
			WebClient webClient = WebClientFactory.Create();
			string url = string.Format(UrlPattern, bookCode);
			string content = webClient.DownloadString(url).Trim();
			content = content.Substring(10);
			content = content.Remove(content.Length - 1);
			var result = JsonConvert.DeserializeObject<RootObject>(content);
			if (result.status != "ok")
				throw new CalameoException("Failed to download book info");
			return result;
		}

	}
}
