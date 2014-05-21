using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CalameoDownloader
{
	static class WebClientFactory
	{
		public static WebClient Create()
		{
			var webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.137 Safari/537.36");
			webClient.Headers.Add("Origin", "http://bookofmormononline.net");
			webClient.Headers.Add("Referer", "http://bookofmormononline.net/");
			return webClient;
		}

	}
}
