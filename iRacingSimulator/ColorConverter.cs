using System;

namespace iRacingSimulator
{
	internal class ColorConverter
	{
		internal static Color ConvertFromString(string hex)
		{
			if (string.IsNullOrWhiteSpace(hex))
				return Colors.White;

			hex = hex.TrimStart('#');

			if (hex.Length == 6)
			{
				byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
				byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
				byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
				return new Color(r, g, b);
			}
			else if (hex.Length == 8)
			{
				byte a = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
				byte r = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
				byte g = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
				byte b = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
				return new Color(r, g, b, a);
			}
			else
			{
				return Colors.White;
			}
		}
	}
}