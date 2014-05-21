using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Content
	{
		public Account account { get; set; }
		public string category { get; set; }
		public string dialect { get; set; }
		public Document document { get; set; }
		public Domains domains { get; set; }
		public Features features { get; set; }
		public string format { get; set; }
		public string id { get; set; }
		public string key { get; set; }
		public string mode { get; set; }
		public string name { get; set; }
		public List<Page> pages { get; set; }
		public Social social { get; set; }
		public Subscription subscription { get; set; }
		public UrlInfo url { get; set; }
	}
}
