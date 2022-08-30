using ACC_Tools.Source;
using AssettoCorsaSharedMemory;
using System.Data;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ACC_Tools
{

	public partial class Form1 : Form
	{
		AssettoCorsa ac;

		List<WeatherTime> weatherTimes;
		bool started;
		public Timer weatherTimer;

		public double weatherInterval
		{
			get
			{
				return weatherTimer.Interval;
			}
			set
			{
				weatherTimer.Interval = value;
			}
		}

		public Form1()
		{

			ac = new(this);

			ac.StaticInfoUpdated += StaticInfoUpdated;
			ac.GraphicsUpdated += GraphicsUpdated;
			ac.PhysicsUpdated += PhysicsUpdated;

			weatherTimer = new Timer();
			weatherTimer.AutoReset = true;
			weatherTimer.Elapsed += weatherTimerElapsed;
			weatherInterval = 10000;
			weatherTimer.Stop();

			weatherTimes = new();

			InitializeComponent();
		}

		void StaticInfoUpdated(object sender, StaticInfoEventArgs e)
		{

		}

		void GraphicsUpdated(object sender, GraphicsEventArgs e)
		{
			gripUpdate(e);
			weatherUpdate(e);			
			WeatherList.Text = e.Graphics.TrackStatus;
		}

		void weatherUpdate(GraphicsEventArgs e)
		{
			AC_RAIN_INTENSITY rainIn30 = e.Graphics.RainIntensityIn30min;
			if (weatherTimes.Count > 1){
				if (rainIn30 != weatherTimes[weatherTimes.Count].Weather)
					weatherTimes.Add(new(DateTime.Now.AddMinutes(30), rainIn30));
			}
		}		

		void gripUpdate(GraphicsEventArgs e)
		{
			TrackStatusLabel.Text = $"Track Status: {e.Graphics.TrackStatus}";
		}

		void PhysicsUpdated(object sender, PhysicsEventArgs e)
		{

		}

		private void StartStopButton_Click(object sender, EventArgs e)
		{
			if (!started) {
				SetStatusLabel("Starting...");
				ac.Start();
				started = true;
				StartStopButton.Text = "Stop";
			} else {
				SetStatusLabel("Stopping...");
				ac.Stop();
				started = false;
				StartStopButton.Text = "Start";
			}
		}

		void weatherTimerElapsed(object sender, ElapsedEventArgs e)
		{
			WeatherList.Items.Clear();

			DateTime current = DateTime.Now;
			if (weatherTimes.Count > 1)			{
				if (DateTime.Compare(current, weatherTimes[1].Time) <= 0)
					weatherTimes.Remove(weatherTimes[0]);
			}

			string[] weatherTimeString = new string[weatherTimes.Count];
			for (int i = 0; i < weatherTimeString.Length; i++)
			{
				string timeString = $"{weatherTimes[i].Time.Hour}:{weatherTimes[i].Time.Minute}";
				string weatherString;
				switch (weatherTimes[i].Weather)
				{
					case AC_RAIN_INTENSITY.AC_NO_RAIN:
						weatherString = "Clear";
						break;
					case AC_RAIN_INTENSITY.AC_DRIZZLE:
						weatherString = "Drizzle";
						break;
					case AC_RAIN_INTENSITY.AC_LIGHT_RAIN:
						weatherString = "Light Rain";
						break;
					case AC_RAIN_INTENSITY.AC_MEDIUM_RAIN:
						weatherString = "Medium Rain";
						break;
					case AC_RAIN_INTENSITY.AC_HEAVY_RAIN:
						weatherString = "Heavy Rain";
						break;
					case AC_RAIN_INTENSITY.AC_THUNDERSTORM:
						weatherString = "Thunderstorm";
						break;
					default:
						weatherString = "Error";
						break;
				}
				if (i == 0)
					timeString = "Current";
				weatherTimeString[i] = $"{timeString} - {weatherString}";
			}
			foreach (string line in weatherTimeString)
			{
				WeatherList.Items.Add(line);
			}
		}


		private void SettingsButton_Click(object sender, EventArgs e)
		{
			SettingsForm setForm = new SettingsForm(this);
			setForm.ShowDialog();
		}

		public void SetStatusLabel(string statusText)
		{
			BeginInvoke(new Action(() => StatusLabel.Text = $"Status: {statusText}"));
		}

		public void SetUpdateIntervals(double staticInterval, double graphicsInterval, double physicsInterval)
		{
			ac.StaticInfoInterval = staticInterval;
			ac.GraphicsInterval = graphicsInterval;
			ac.PhysicsInterval = physicsInterval;
		}

		public double[] GetUpdateIntervals()
		{
			double[] intervals = new double[] { ac.StaticInfoInterval, ac.GraphicsInterval, ac.PhysicsInterval };
			return intervals;
		}

		public void SetStartWeather(AC_RAIN_INTENSITY weather)
		{
			weatherTimes.Add(new(DateTime.Now, weather));
		}
	}
}