using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Skin
	{
		public bool allowExternalUrl { get; set; }
		public bool allowstyleurl { get; set; }
		public string fallback { get; set; }
		public string url { get; set; }
	}
}
