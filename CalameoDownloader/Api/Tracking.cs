using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalameoDownloader.Api
{
	public class Tracking
	{
		public Calameo calameo { get; set; }
		public Customer customer { get; set; }
		public Intern intern { get; set; }
		public CodedEnabled quantcast { get; set; }
	}
}
