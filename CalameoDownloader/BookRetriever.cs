using CalameoDownloader.Api;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CalameoDownloader
{
	class BookRetriever
	{
		public void GetPages(
			RootObject bookInfo, 
			string destinationDirectory,
			Action<int, int> progress)
		{
			var pageUrls = bookInfo
				.content
				.pages
				.Select(page => page.i.u)
				.ToList();
			string lastPageNumber = pageUrls.Count.ToString();
			int pageNumberLength = lastPageNumber.Length;
			for (int index = 0; index < pageUrls.Count; index++)
			{
				string pageNumberAsText = (index + 1).ToString("D" + pageNumberLength);
				string fileExtension = Path.GetExtension(pageUrls[index]);
				string localFilePath = Path.Combine(
					destinationDirectory,
					bookInfo.content.key 
					+ "_" 
					+ pageNumberAsText
					+ fileExtension);
				if (!File.Exists(localFilePath))
				{
					GetPage(
						downloadUrl: bookInfo.content.domains.image,
						bookUniqueKey: bookInfo.content.key,
						pageID: pageUrls[index],
						pageNumber: index + 1,
						localFilePath: localFilePath
					);
				}
				progress(index + 1, pageUrls.Count);
			}

		}

		void GetPage(
			string downloadUrl,
			string bookUniqueKey, 
			string pageID, 
			int pageNumber,
			string localFilePath)
		{
			var baseUri = new Uri(downloadUrl);
			var pageUri = new Uri(baseUri, bookUniqueKey + "/" + pageID);
			try
			{
				var webClient = WebClientFactory.Create();
				var data = webClient.DownloadData(pageUri);
				ProcessData(localFilePath, data);
			}
			catch (WebException webException)
			 {
				throw new CalameoException(webException.Message);
			}
		}

		static void ProcessData(string localFilePath, byte[] data)
		{
			using (var fs = File.Create(localFilePath))
			{
				fs.Write(data, 0, data.Length);
			}
		}
	}
}
