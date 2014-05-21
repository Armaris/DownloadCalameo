using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Features
	{
		public ApiInfo api { get; set; }
		public Audio audio { get; set; }
		public string background { get; set; }
		public Branding branding { get; set; }
		public Download download { get; set; }
		public Links links { get; set; }
		public Localization localization { get; set; }
		public Logo logo { get; set; }
		public Mini mini { get; set; }
		public Modules modules { get; set; }
		public ModedUrl music { get; set; }
		public Print print { get; set; }
		public Related related { get; set; }
		public Search search { get; set; }
		public ModedUrl sfx { get; set; }
		public Share share { get; set; }
		public Skin skin { get; set; }
		public Subscribers subscribers { get; set; }
		public Toc toc { get; set; }
		public Tracking tracking { get; set; }
		public Video video { get; set; }
		public Viewer viewer { get; set; }
	}
}
