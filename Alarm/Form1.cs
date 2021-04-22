using System;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Form1 : Form
    {
        int hrs;
        int mins;
        int secs;
        int totalTime;

        TimeSpan alarmTime;
        TimeSpan timeRemaining;
        TimeSpan timeStarted;
        TimeSpan totalTimeSpan;

        bool alarmSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoursUpDown_ValueChanged(object sender, EventArgs e)
        {
            hrs = (int)hoursUpDown.Value;
        }

        private void minsUpDown_ValueChanged(object sender, EventArgs e)
        {
            mins = (int)minsUpDown.Value;
        }

        private void secondsUpDown_ValueChanged(object sender, EventArgs e)
        {
            secs = (int)secondsUpDown.Value;
        }

        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            if(alarmSet == false)
            {
                if (hrs > 0)
                {
                    totalTime = hrs * 3600000 + totalTime;
                }

                if (mins > 0)
                {
                    totalTime = mins * 60000 + totalTime;
                }

                if (secs > 0)
                {
                    totalTime = secs * 1000 + totalTime;
                }

                if (totalTime > 0)
                {
                    StartTimer();
                    setAlarmButton.Text = "Stop Alarm";
                }
            }
            else
            {
                alarmSet = false;
                StopTimer();
                setAlarmButton.Text = "Set Alarm";
                soundPlayTimer.Enabled = false;
            }
        }

        private void StartTimer()
        {
            alarmSet = true;
            mainAlarm.Interval = totalTime;
            mainAlarm.Enabled = true;
            timeStarted = DateTime.Now.TimeOfDay;
            totalTimeSpan = TimeSpan.FromMilliseconds(totalTime);
            alarmTime = DateTime.Now.TimeOfDay + totalTimeSpan;

            progressBar1.Visible = true;
            timeRemainingLabel.Visible = true;
            hrsRemaining.Visible = true;
            minsRemaining.Visible = true;
            secsRemaining.Visible = true;
        }

        private void StopTimer()
        {
            totalTime = 0;
            hrs = 0;
            mins = 0;
            secs = 0;

            mainAlarm.Enabled = false;

            hrsRemaining.ResetText();
            minsRemaining.ResetText();
            secsRemaining.ResetText();

            hoursUpDown.Value = 0;
            minsUpDown.Value = 0;
            secondsUpDown.Value = 0;

            progressBar1.Value = 0;
            progressBar1.Visible = false;

            timeRemainingLabel.Visible = false;
            hrsRemaining.Visible = false;
            minsRemaining.Visible = false;
            secsRemaining.Visible = false;
        }

        private void mainAlarm_Tick(object sender, EventArgs e)
        {
            soundPlayTimer.Enabled = true;
            StopTimer();
        }

        private void timeRemainingUpdater_Tick(object sender, EventArgs e)
        {
            if(mainAlarm.Enabled == true)
            {
                timeRemaining = alarmTime - DateTime.Now.TimeOfDay;
                hrsRemaining.Text = Math.Floor(timeRemaining.TotalHours).ToString();
                minsRemaining.Text = timeRemaining.Minutes.ToString();
                secsRemaining.Text = timeRemaining.Seconds.ToString();
                progressBar1.Value = GetPercentageOfTimeLeft();
            }
        }

        private int GetPercentageOfTimeLeft()
        {
            TimeSpan timePassed = DateTime.Now.TimeOfDay - timeStarted;
            var doubleOfTimeLeft = (double)timePassed.Ticks / (double)totalTimeSpan.Ticks;
            doubleOfTimeLeft = Math.Abs(doubleOfTimeLeft) * 100;
            return (int)Math.Floor(doubleOfTimeLeft);
        }

        private void soundPlayTimer_Tick(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }
    }
}
