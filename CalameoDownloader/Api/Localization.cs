using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Localization
	{
		public bool allowExternalUrl { get; set; }
		public List<string> allowedInternLanguages { get; set; }
		public string fallback { get; set; }
		public string url { get; set; }
	}
}
