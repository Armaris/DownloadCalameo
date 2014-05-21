using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace CalameoDownloader
{
	static class BookCodeExtractor
	{
		public static string GetBookCode(string sourceUrl)
		{
			string content = DownloadHtml(sourceUrl);
			string result = ExtractBookCode(content);
			return result;
		}

		static string DownloadHtml(string sourceUrl)
		{
			string content;
			try
			{
				var webClient = WebClientFactory.Create();
				content = webClient.DownloadString(sourceUrl);
				if (content.ToLowerInvariant().Contains("offline"))
					throw new CalameoException("Site is currently offline");
			}
			catch (WebException webException)
			{
				throw new CalameoException(webException.Message);
			}
			return content;
		}

		static string ExtractBookCode(string content)
		{
			string pattern = @"<\s*param\s+name\s*=\s*""flashvars""\s+value\s*=\s*"".*?bkcode=([0-9a-zA-Z]+)";
			var regex = new Regex(pattern);
			var match = regex.Match(content);
			if (!match.Success)
				throw new CalameoException("book code not found in url");
			return match.Groups[1].Value;
		}

	}
}
