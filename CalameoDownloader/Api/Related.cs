﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Related
	{
		public bool enabled { get; set; }
		public string fallback { get; set; }
		public SearchParams @params { get; set; }
		public string url { get; set; }
	}
}
