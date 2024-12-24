namespace iRacingSimulator
{
	public struct Color
	{
		public byte A { get; }
		public byte R { get; }
		public byte G { get; }
		public byte B { get; }

		public Color(byte r, byte g, byte b, byte a = 255)
		{
			A = a;
			R = r;
			G = g;
			B = b;
		}

		public override string ToString()
		{
			if (A == 255)
				return $"#{R:X2}{G:X2}{B:X2}";
			return $"#{A:X2}{R:X2}{G:X2}{B:X2}";
		}

		public override bool Equals(object obj)
		{
			if (obj is Color other)
			{
				return this.A == other.A && this.R == other.R && this.G == other.G && this.B == other.B;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return A.GetHashCode() ^ R.GetHashCode() << 24 ^ G.GetHashCode() << 16 ^ B.GetHashCode() << 8;
		}

		public static bool operator ==(Color c1, Color c2) => c1.Equals(c2);
		public static bool operator !=(Color c1, Color c2) => !c1.Equals(c2);
	}
}