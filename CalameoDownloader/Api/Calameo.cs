using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Calameo
	{
		public CodedEnabled embed { get; set; }
		public Events events { get; set; }
		public CodedUrl mini { get; set; }
		public CodedUrl view { get; set; }
	}
}
