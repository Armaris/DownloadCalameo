using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Video
	{
		public EnabledInfo dailymotion { get; set; }
		public EnabledInfo vimeo { get; set; }
		public EnabledInfo youtube { get; set; }
	}
}
