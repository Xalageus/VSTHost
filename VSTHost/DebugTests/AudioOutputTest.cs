using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Threading;

namespace VSTHost
{
    public partial class AudioOutputTest : Form
    {
        WaveOutEvent wo;

        public AudioOutputTest()
        {
            InitializeComponent();
            audioTypeCB.SelectedIndex = 0;
            playbackStatusLabel.Text = "";
        }

        private void PlaySineWave()
        {
            var sineWave = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.Sin
            }.Take(TimeSpan.FromSeconds(20));

            using (wo = new WaveOutEvent())
            {
                wo.Init(sineWave);
                int avgBytes = wo.OutputWaveFormat.AverageBytesPerSecond;
                wo.Play();
                while(wo.PlaybackState == PlaybackState.Playing)
                {
                    updatePlaybackStatus(wo, 20, avgBytes, "Sine Wave");
                    Thread.Sleep(500);
                }
                updatePlaybackStatus(wo, 20, avgBytes, "Sine Wave");
            }
        }

        private void PlaySawtooth()
        {
            var sawtooth = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.SawTooth
            }.Take(TimeSpan.FromSeconds(20));

            using (wo = new WaveOutEvent())
            {
                wo.Init(sawtooth);
                int avgBytes = wo.OutputWaveFormat.AverageBytesPerSecond;
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    updatePlaybackStatus(wo, 20, avgBytes, "Sawtooth");
                    Thread.Sleep(500);
                }
                updatePlaybackStatus(wo, 20, avgBytes, "Sawtooth");
            }
        }

        private void PlayWhiteNoise()
        {
            var whiteNoise = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.White
            }.Take(TimeSpan.FromSeconds(20));

            using (wo = new WaveOutEvent())
            {
                wo.Init(whiteNoise);
                int avgBytes = wo.OutputWaveFormat.AverageBytesPerSecond;
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    updatePlaybackStatus(wo, 20, avgBytes, "White Noise");
                    Thread.Sleep(500);
                }
                updatePlaybackStatus(wo, 20, avgBytes, "White Noise");
            }
        }

        private void updatePlaybackStatus(WaveOutEvent wo, int totalTime, int AvgBytesPerSecond,  string type)
        {
            if(wo.PlaybackState == PlaybackState.Playing)
            {
                int currentPos = (int)wo.GetPosition() / AvgBytesPerSecond;
                playbackStatusLabel.Invoke((Action)delegate
                {
                    playbackStatusLabel.Text = "Playing " + type + "... (" + currentPos.ToString() + "/" + totalTime.ToString() + ")";
                });
            }else if(wo.PlaybackState == PlaybackState.Stopped)
            {
                playbackStatusLabel.Invoke((Action)delegate
                {
                    playbackStatusLabel.Text = "Stopped";
                });
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            switch (audioTypeCB.SelectedIndex)
            {
                case 0:
                    Thread sineThread = new Thread(PlaySineWave);
                    sineThread.Start();
                    break;
                case 1:
                    Thread sawThread = new Thread(PlaySawtooth);
                    sawThread.Start();
                    break;
                case 2:
                    Thread whiteThread = new Thread(PlayWhiteNoise);
                    whiteThread.Start();
                    break;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                wo.Stop();
                playbackStatusLabel.Text = "Stopped";
            }
            catch (NullReferenceException)
            {
                //Do Nothing
            }
        }
    }
}
