using System;
using System.Text;

namespace OpenEmma
{
	public static class oeEncoding
	{
		public enum EncodingType {
			ASCII_US,
			UTF8,
			UTF16_LITTLE_ENDIAN,
			UTF16_BIG_ENDIAN,
			UTF32
		}

		public static Encoding GetEncoding(EncodingType type) {
			switch (type) {
			case EncodingType.UTF8:
				return new UTF8Encoding(true, true);
			case EncodingType.UTF16_LITTLE_ENDIAN:
				return new UnicodeEncoding (false, true, true);
			case EncodingType.UTF16_BIG_ENDIAN:
				return new UnicodeEncoding(true, true, true);
			case EncodingType.UTF32:
				return new UTF32Encoding(false, true, true);
			case EncodingType.ASCII_US:
			default:
				return Encoding.GetEncoding("us-ascii", 
					new EncoderExceptionFallback(),
					new DecoderExceptionFallback());
			}
		}

	}

}

