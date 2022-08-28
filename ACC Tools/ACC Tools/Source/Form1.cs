using AssettoCorsaSharedMemory;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading;

namespace ACC_Tools
{

    public partial class Form1 : Form
    {
        Timer updateTimer;

        AssettoCorsa ac;

        public Form1()
        {
            updateTimer = new();
            updateTimer.Interval = 1000;
            updateTimer.Elapsed += new ElapsedEventHandler(UpdateTimerEvent);

            ac = new(this);
            ac.Start();

            InitializeComponent();
        }

        public void startUpdateTimer()
		{
			updateTimer.Start();
            StatusLabel.Text = "Status: Connected";
		}

        public void stopUpdateTimer()
        {
            updateTimer.Stop();
            if(StatusLabel != null)
                StatusLabel.Text = "Status: Not Connected";
        }

        void UpdateTimerEvent(object sender, ElapsedEventArgs args)
        {
            try
            {
                AC_TRACK_GRIP_STATUS grip = ac.ReadGraphics().TrackGripStatus;
                string gripString;
                if (grip == AC_TRACK_GRIP_STATUS.AC_GREEN)
                    gripString = "Green";
                else if (grip == AC_TRACK_GRIP_STATUS.AC_FAST)
                    gripString = "Fast";
                else if (grip == AC_TRACK_GRIP_STATUS.AC_OPTIMUM)
                    gripString = "Optimum";
                else if (grip == AC_TRACK_GRIP_STATUS.AC_GREASY)
                    gripString = "Greasy";
                else if (grip == AC_TRACK_GRIP_STATUS.AC_DEMP)
                    gripString = "Damp";
                else if (grip == AC_TRACK_GRIP_STATUS.AC_WET)
                    gripString = "Wet";
                else
                    gripString = "Flooded";

                TrackStatusLabel.Text = $"Track Status: {gripString}";
            }
            catch(InvalidOperationException e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}