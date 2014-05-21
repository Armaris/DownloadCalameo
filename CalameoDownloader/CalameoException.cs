using System;

namespace CalameoDownloader
{
	public class CalameoException : Exception
	{
		public CalameoException(string message)
			: base(message) { }
	}
}
