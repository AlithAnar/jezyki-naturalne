using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NoteGenerator
    {
    public abstract class FrequencyInfoSource
        {
        public abstract void Listen();
        public abstract void Stop();

        public event EventHandler<FrequencyDetectedEventArgs> FrequencyDetected;
        public event EventHandler<DataChunkDetectedEventArgs> DataChunkDetected;


        protected void OnFrequencyDetected(FrequencyDetectedEventArgs e)
            {
            if (FrequencyDetected != null)
                {
                FrequencyDetected(this, e);
                }
            }

        protected void OnDataChunkDetected(DataChunkDetectedEventArgs e)
            {
            if (DataChunkDetected != null)
                {
                DataChunkDetected(this, e);
                }
            }
        }

    public class FrequencyDetectedEventArgs : EventArgs
        {
        double frequency;

        public double Frequency
            {
            get { return frequency; }
            }

        public FrequencyDetectedEventArgs(double frequency)
            {
            this.frequency = frequency;
            }
        }

    public class DataChunkDetectedEventArgs : EventArgs
        {
        short[] data;

        public short[] Data
            {
            get { return data; }
            }

        public DataChunkDetectedEventArgs(short[] data)
            {
            this.data = data;
            }
        }
    }
