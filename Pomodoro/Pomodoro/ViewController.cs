using System;
using System.Timers;

using AppKit;
using Foundation;

namespace Pomodoro
{
    public partial class ViewController : NSViewController
    {
        Timer MainTimer;
        int TimeLeft = 1500; // 1500 seconds in 25 minutes

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            MainTimer = new Timer(1000);
            MainTimer.Elapsed += (sender, e) =>
            {
                TimeLeft--;
                // Format the remaining time nicely for the label
                TimeSpan time = TimeSpan.FromSeconds(TimeLeft);
                string timeString = time.ToString(@"mm\:ss");
                InvokeOnMainThread(() => 
                {
                    // We want to interact with the UI from a different thread,
                    // so we must invoke this change on the main thread
                    TimerLabel.StringValue = timeString;
				});

                if (TimeLeft == 0)
                {
                    // Stop the timer and reset
                    MainTimer.Stop();
                    TimeLeft = 1500;
                    InvokeOnMainThread(() =>
                    {
                        // Reset the UI
                        TimerLabel.StringValue = "25:00";
                        StartStopButton.Title = "Start";
                    });
                }
            };
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
