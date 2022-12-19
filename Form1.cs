using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        System.Timers.Timer time;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = new System.Timers.Timer();
            time.Interval = 1000; // 1 Second
            time.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                // set ones second counter value
                onesSecondCounter.Value--;
                if (tensMinuteCounter.Value == 0 && onesMinuteCounter.Value == 0 && tensSecondCounter.Value == 0 && onesSecondCounter.Value == -1)
                {
                    onesSecondCounter.Value = 0;
                    time.Stop();
                    controlButton.Text = "Start";

                    onesSecondCounter.Enabled = true;

                    tensSecondCounter.Enabled = true;

                    onesMinuteCounter.Enabled = true;

                    tensMinuteCounter.Enabled = true;
                }
                else if (onesSecondCounter.Value == -1)
                {
                    onesSecondCounter.Value = 9;
                    tensSecondCounter.Value--;
                }

                // set tens second counter value
                if (tensMinuteCounter.Value == 0 && onesMinuteCounter.Value == 0 && tensSecondCounter.Value == -1 && onesSecondCounter.Value == 0)
                {
                    tensSecondCounter.Value = 0;
                }
                else if (tensSecondCounter.Value == -1)
                {
                    tensSecondCounter.Value = 5;
                    onesMinuteCounter.Value--;
                }

                // set ones minute counter value
                if (tensMinuteCounter.Value == 0 && onesMinuteCounter.Value == -1 && tensSecondCounter.Value == 0 && onesSecondCounter.Value == 0)
                {
                    onesMinuteCounter.Value = 0;
                }
                else if (onesMinuteCounter.Value == -1)
                {
                    onesMinuteCounter.Value = 9;
                    tensMinuteCounter.Value--;
                }

                // set tens minute counter value
                if (tensMinuteCounter.Value == -1)
                {
                    tensMinuteCounter.Value = 0;
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (controlButton.Text == "Start")
            {
                if (tensMinuteCounter.Value == -1 && onesMinuteCounter.Value == -1 && tensSecondCounter.Value == -1 && onesSecondCounter.Value == -1)
                {
                    tensMinuteCounter.Value = 0;
                    onesMinuteCounter.Value = 0;
                    tensSecondCounter.Value = 0;
                    onesSecondCounter.Value = 0;
                }
                else
                {
                    controlButton.Text = "Stop";

                    onesSecondCounter.Enabled = false;

                    tensSecondCounter.Enabled = false;

                    onesMinuteCounter.Enabled = false;

                    tensMinuteCounter.Enabled = false;

                    time.Start();
                }
            }
            else
            {
                time.Stop();
                controlButton.Text = "Start";

                onesSecondCounter.Enabled = true;

                tensSecondCounter.Enabled = true;

                onesMinuteCounter.Enabled = true;

                tensMinuteCounter.Enabled = true;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            time.Stop();
            Application.DoEvents();
        }
    }
}
