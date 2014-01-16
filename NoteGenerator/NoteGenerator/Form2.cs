
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
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
using System.Windows.Forms.DataVisualization.Charting;


namespace NoteGenerator
    {
    public partial class Form2 : Form
        {

        SoundCaptureDevice[] devices;
        bool isListening = false;
        public bool IsListening
            {
            get { return isListening; }
            }


        public SoundCaptureDevice SelectedDevice
            {
            get
                {
                if (listDevices.SelectedIndex != -1)
                    return devices[listDevices.SelectedIndex];
                else return null;
                }
            }
        public Form2()
            {
            InitializeComponent();
            devices = SoundCaptureDevice.GetDevices();
            for (int i = 0; i < devices.Length; i++)
                {
                listDevices.Items.Add(devices[i].Name);
                }

            chart1.Series.Add("Frequency");
            chart1.Series["Frequency"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Frequency"].ChartArea = "ChartArea1";
            }

        FrequencyInfoSource frequencyInfoSource;

        private void recordStream(object sender, EventArgs e)
            {
            SoundCaptureDevice device = null;
            device = SelectedDevice;

            if (device != null)
                {
                listen(device);
                }
            }

        void frequencyInfoSource_FrequencyDetected(object sender, FrequencyDetectedEventArgs e)
            {
            if (InvokeRequired)
                {
                BeginInvoke(new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected), sender, e);
                }
            else
                {
                if (e.Frequency != 0)
                    {
                    freqLabel.Text = "FREQ: " + e.Frequency;
                    noteView.AddNote(e.Frequency);
                    noteView.Refresh();
                    addDataPoint(e);
                    }
                }
            }

        public void addDataPoint(FrequencyDetectedEventArgs e)
            {
            if (this.InvokeRequired)
                {// this prevents the invoke loop
                this.Invoke(new Action<FrequencyDetectedEventArgs>(addDataPoint), new object[] { e }); // invoke call for _THIS_ function to execute on the UI thread
                }
            else
                {
                //function logic to actually add the datapoint goes here
                chart1.Series["Frequency"].Points.Add(e.Frequency); // assuming your dataclass has the members X and Y and you are using the first Series on a MSChart control
                }
            }

        private void listen(SoundCaptureDevice device)
            {
            isListening = true;
            frequencyInfoSource = new SoundFrequencyInfoSource(device);
            frequencyInfoSource.FrequencyDetected += new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected);
            frequencyInfoSource.Listen();

            }

        private void stopListening(object sender, EventArgs e)
            {
            isListening = false;
            frequencyInfoSource.Stop();
            frequencyInfoSource = null;
            }

        private void seveButton_Click(object sender, EventArgs e)
            {
            try
                {
                if (saveFileNoteDialog.ShowDialog() == DialogResult.OK)
                    {
                    StringBuilder sb = new StringBuilder();
                    List<double> temp = noteView.hzs;
                    foreach (double item in temp)
                        {
                        sb.Append(item);
                        sb.Append("\t");
                        }
                    StreamWriter sw = new StreamWriter(saveFileNoteDialog.FileName);
                    sw.Write(sb.ToString());
                    sw.Close();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Form2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void openButton_Click(object sender, EventArgs e)
            {
            try
                {
                if (openFileNoteDialog.ShowDialog() == DialogResult.OK)
                    {
                    radioButtonOpen.Enabled = true;
                    radioButtonOpen.Checked = true;
                    String temp = File.ReadAllText(openFileNoteDialog.FileName);
                    int countT = 0;
                    for (int i = 0; i < temp.Count(); i++)
                        {
                        if (temp.ElementAt(i) == '\t')
                            {
                            countT++;
                            }
                        }
                    String[] temp2 = temp.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (String item in temp2)
                        {
                        noteView2.AddNote(Convert.ToDouble(item));
                        }
                    noteView2.Refresh();

                    //File.ReadAllText(openFileNoteDialog.FileName);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Form2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void radioButtonRecorder_CheckedChanged(object sender, EventArgs e)
            {
            noteView.Visible = true;
            noteView2.Visible = false;
            }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
            {
            noteView.Visible = false;
            noteView2.Visible = true;
            }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        SecondaryBuffer buffer;
        int bufferLength;
        private void loadFile(object sender, EventArgs e)
            {
            var dev = new Device();
            dev.SetCooperativeLevel(this, CooperativeLevel.Normal);


            using (OpenFileDialog dialog = new OpenFileDialog())
                {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                    using (MemoryStream ms = new MemoryStream())
                        {
                        byte[] bytes;
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                            {
                            bytes = new byte[fs.Length];
                            fs.Read(bytes, 0, (int)fs.Length);
                            ms.Write(bytes, 0, (int)fs.Length);
                            }
                        bufferLength = (int)ms.Length;
                        buffer = new SecondaryBuffer(dialog.FileName, dev);
                        buffer.Play(0, BufferPlayFlags.Default);
                        int nextCapturePosition = 0;
                        int start = 0;
                        while (start<bufferLength)
                            {
                            int length = bufferLength/(bufferLength / (44100 * 2));
                           // int capturePosition = buffer.PlayPosition;
                           // int readPosition = buffer.PlayPosition;
                           

                            //int lockSize = readPosition - nextCapturePosition;
                           // if (lockSize < 0) lockSize += length;
                            //if ((lockSize & 1) != 0) lockSize--;

                           // int itemsCount = lockSize >> 1;
                             //Console.WriteLine(bufferLength + " | " + start);
                            
                                short[] data = (short[])buffer.Read(start, typeof(short), LockFlag.None, length);
                                Console.WriteLine(ProcessData(data));
                                noteView.AddNote(ProcessData(data));
                                noteView.Refresh();


                             if (!(start + length >= bufferLength-length))
                                 {
                                 start += length;
                                 }
                             else break;
                            //nextCapturePosition = (nextCapturePosition + lockSize) % length;
                            
                            }


                        }
                    }
                }
            }


        protected double ProcessData(short[] data)
            {
            double[] x = new double[data.Length];
            for (int i = 0; i < x.Length; i++)
                {
                x[i] = data[i] / 32768.0;
                }

            return FrequencyUtils.FindFundamentalFrequency(x, 44100, 60, 1300);
            }




        }

    }



