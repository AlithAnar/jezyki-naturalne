using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NoteGenerator 
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;

        private void openAudioFile(object sender, EventArgs e)
            {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio file (*.mp3;*.wav)|*mp3;*wav;";
            if (dialog.ShowDialog() != DialogResult.OK) return;

            DisposeWave();

            if (dialog.FileName.EndsWith(".mp3"))
                {
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(dialog.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                }
            else if (dialog.FileName.EndsWith(".wav"))
                {
                chart1.Series.Add("wave");
                chart1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series["wave"].ChartArea = "ChartArea1";

                NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(dialog.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);

                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                output.Play();

                //Thread.Sleep(stream.TotalTime);


                byte[] buffer = new byte[16384];
                int read = 0;
                while (pcm.Position < pcm.Length)
                    {
                    read = pcm.Read(buffer, 0, 16384);
                    for (int i = 0; i < read / 4; i++)
                        {
                        chart1.Series["wave"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                        }
                    }
                
                }
            else throw new InvalidOperationException("Zly typ pliku");

            
            ppBtn.Enabled = true;
            }

        private void ppBtn_Click(object sender, EventArgs e)
            {
            if (output != null)
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }

        private void DisposeWave()
            {
            if (output != null)
                {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
                }

            if (stream != null)
                {
                stream.Dispose();
                stream = null;
                }

            if (waveWriter != null)
                {
                waveWriter.Dispose();
                waveWriter = null;
                }
            }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
            DisposeWave();
            }

        private void refreshBtn_Click(object sender, EventArgs e)
            {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
                }

            listBox1.Items.Clear();

            foreach (var source in sources)
                {
                listBox1.Items.Add(source.ProductName);
                }
            }


        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;
        private NAudio.Wave.WaveFileWriter waveWriter = null;

        private void recordBtn_Click(object sender, EventArgs e)
            {
            if (listBox1.SelectedItems.Count == 0) return;

            int deviceNumber = listBox1.SelectedIndex;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.DataAvailable += sourcestream_DataAvailable;
            // sourceStream.RecordingStopped += new EventHandler<NAudio.Wave.StoppedEventArgs>(sourveStream_recordingStopped);
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);
            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(waveIn);
            //sampleAggregator = new SampleAggregator();
            sourceStream.StartRecording();
            waveOut.Play();


            }

        private void flushAll(object sender, EventArgs e)
            {
            if (waveOut != null)
                {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
                }
            if (sourceStream != null)
                {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
                }
            }

        private void recordAudioFile(object sender, EventArgs e)
            {
            if (listBox1.SelectedItems.Count == 0) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave file (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;
            int deviceNumber = listBox1.SelectedIndex;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourcestream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);
            sourceStream.StartRecording();
            }

        private void sourcestream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
            {
            if (waveWriter == null) return;

            byte[] buffer = e.Buffer;
            int bytesRecorded = e.BytesRecorded;
            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            for (int index = 0; index < e.BytesRecorded; index += 2)
                {
                short sample = (short)((buffer[index + 1] << 8) |
                                        buffer[index + 0]);
                float sample32 = sample / 32768f;
                
                }
            waveWriter.Flush();
            }


        public EventHandler<NAudio.Wave.StoppedEventArgs> sourveStream_recordingStopped { get; set; }
        }



    }
