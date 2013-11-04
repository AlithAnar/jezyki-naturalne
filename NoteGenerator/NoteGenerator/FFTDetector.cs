using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteGenerator
    {
    class FFTDetector
        {
        private IWaveProvider source;
        private int sampleRate;
        private WaveBuffer waveBuffer;
        private float[] prevBuffer;
        private float[] fftBuffer;
        public FFTDetector(IWaveProvider source)
            {
            this.source = source;
            this.sampleRate = source.WaveFormat.SampleRate;
            }

        public int Read(byte[] buffer, int offset, int count)
            {
            if (waveBuffer == null || waveBuffer.MaxSize < count)
                {
                waveBuffer = new WaveBuffer(count);
                }

            int bytesRead = source.Read(waveBuffer, 0, count);

            if (bytesRead > 0) bytesRead = count;

            int frames = bytesRead / sizeof(float);
            float pitch = DetectPitch(waveBuffer.FloatBuffer, frames);

            Console.WriteLine("Freq: " + pitch);
            return frames * 4;
            }

        public float DetectPitch(float[] buffer, int inFrames)
            {
            Func<int, int, float> window = HammingWindow;
            if (prevBuffer == null)
                {
                prevBuffer = new float[inFrames];
                }

            // double frames since we are combining present and previous buffers
            int frames = inFrames * 2;
            if (fftBuffer == null)
                {
                fftBuffer = new float[frames * 2]; // times 2 because it is complex input
                }

            for (int n = 0; n < frames; n++)
                {
                if (n < inFrames)
                    {
                    fftBuffer[n * 2] = prevBuffer[n] * window(n, frames);
                    fftBuffer[n * 2 + 1] = 0; // need to clear out as fft modifies buffer
                    }
                else
                    {
                    fftBuffer[n * 2] = buffer[n - inFrames] * window(n, frames);
                    fftBuffer[n * 2 + 1] = 0; // need to clear out as fft modifies buffer
                    }
                }

            float binSize = sampleRate / frames;
            int minBin = (int)(85 / binSize);
            int maxBin = (int)(300 / binSize);

            float maxIntensity = 0f;
            int maxBinIndex = 0;

            for (int bin = minBin; bin <= maxBin; bin++)
                {
                float real = fftBuffer[bin * 2];
                float imaginary = fftBuffer[bin * 2 + 1];
                float intensity = real * real + imaginary * imaginary;
                if (intensity > maxIntensity)
                    {
                    maxIntensity = intensity;
                    maxBinIndex = bin;
                    }
                }

            return binSize * maxBinIndex;
            }

        private float HammingWindow(int n, int N)
            {
            return 0.54f - 0.46f * (float)Math.Cos((2 * Math.PI * n) / (N - 1));
            }

        }
    }
