using AssettoCorsaSharedMemory;

namespace ACC_Tools
{

	public class WeatherTime
	{

		public DateTime Time { get; }
		public AC_RAIN_INTENSITY Weather { get; }

		public WeatherTime(DateTime Time, AC_RAIN_INTENSITY Weather)
		{
			this.Time = Time;
			this.Weather = Weather;
		}

	}
}
