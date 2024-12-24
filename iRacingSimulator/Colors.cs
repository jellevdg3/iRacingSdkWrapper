namespace iRacingSimulator
{
	internal class Colors
	{
		public static Color White { get; internal set; }
		public static Color Black { get; internal set; }
		public static Color DarkGray { get; internal set; }

		static Colors()
		{
			White = new Color(255, 255, 255);
			Black = new Color(0, 0, 0);
			DarkGray = new Color(169, 169, 169);
		}
	}
}