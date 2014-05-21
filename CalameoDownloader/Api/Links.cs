using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Links
	{
		public bool enabled { get; set; }
		public string fallback { get; set; }
		public List<object> schema { get; set; }
		public string url { get; set; }
	}
}
