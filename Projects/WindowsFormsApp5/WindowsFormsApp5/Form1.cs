using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NAudio.Wave; 
using NAudio.CoreAudioApi;
using System.Numerics;


namespace microphone
{
    //public partial class Form1 : Form
    //{
    //    BufferedWaveProvider bufferStream;
    //    Thread in_thread;
    //    public WaveIn wi;
    //    public BufferedWaveProvider bwp;
    //    public Int32 envelopeMax;
    //    NAudio.Wave.DirectSoundOut waveOut = null;
    //    private int RATE = 44100; // sample rate of the sound card
    //    private int BUFFERSIZE = (int)Math.Pow(2, 13); // must be a multiple of 2
    //                                                   //private int BUFFERSIZE = 2048; // must be a multiple of 2

    //    public Form1()
    //    {
    //        InitializeComponent();

    //        // see what audio devices are available
    //        int devcount = WaveIn.DeviceCount;
    //        Console.Out.WriteLine("Device Count: {0}.", devcount);

    //        // get the WaveIn class started
    //        WaveIn wi = new WaveIn();
    //        wi.DeviceNumber = 0;
    //        wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);

    //        // create a wave buffer and start the recording
    //        wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
    //        bwp = new BufferedWaveProvider(wi.WaveFormat);
    //        bwp.BufferLength = BUFFERSIZE * 2;
    //        NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(wi);
    //        //waveOut = new NAudio.Wave.DirectSoundOut();

    //        wi.StartRecording();
    //        //  in_thread = new Thread(new ThreadStart(Listening));
    //        ////запускаем его
    //        //in_thread.Start();
    //    }

    //    WindowsFormsApp5.Form2 f = new WindowsFormsApp5.Form2();
    //    //byte[] data = new byte[655350000];
    //    public int d = 0;
    //    private void Listening()

    //    {

    //       waveOut = new NAudio.Wave.DirectSoundOut(d);
    //       waveOut.Init(samples);
    //      waveOut.Play();



    //    }
    //    ISampleProvider samples;





    //            void wi_DataAvailable(object sender, WaveInEventArgs e)
    //    {
    //        WaveIn wi = new WaveIn();
    //        wi.DeviceNumber = 0;
    //        wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);

    //        samples = bwp.ToSampleProvider();
    //        //IWaveProvider r = new BufferedWaveProvider(wi.WaveFormat);
    //        bwp.DiscardOnBufferOverflow = true;
    //        bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
    //        //bwp.Read(data,0, e.BytesRecorded);
    //        var bytesPerFrame = wi.WaveFormat.BitsPerSample / 8
    //                 * wi.WaveFormat.Channels;
    //        var bufferedFrames = bwp.BufferedBytes / bytesPerFrame;

    //        var frames = new float[bufferedFrames];
    //        samples.Read(frames, 0, bufferedFrames);
    //        //r.Read(data, 0, e.BytesRecorded);
    //    }

    //    public void UpdateAudioGraph(object w, EventArgs x)
    //    {
    //        // read the bytes from the stream
    //        int frameSize = BUFFERSIZE;
    //        var frames = new byte[frameSize];
    //        bwp.Read(frames, 0, frameSize);
    //        if (frames.Length == 0) return;
    //        if (frames[frameSize - 2] == 0) return;

    //        timer2.Enabled = false;

    //        // convert it to int32 manually (and a double for scottplot)
    //        int SAMPLE_RESOLUTION = 16;
    //        int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
    //        Int32[] vals = new Int32[frames.Length / BYTES_PER_POINT];
    //        double[] Ys = new double[frames.Length / BYTES_PER_POINT];
    //        double[] Xs = new double[frames.Length / BYTES_PER_POINT];
    //        double[] Ys2 = new double[frames.Length / BYTES_PER_POINT];
    //        double[] Xs2 = new double[frames.Length / BYTES_PER_POINT];
    //        for (int i = 0; i < vals.Length; i++)
    //        {
    //            // bit shift the byte buffer into the right variable format
    //            byte hByte = frames[i * 2 + 1];
    //            byte lByte = frames[i * 2 + 0];
    //            vals[i] = (int)(short)((hByte << 8) | lByte);
    //            Xs[i] = i;
    //            Ys[i] = vals[i];
    //            Xs2[i] = (double)i / Ys.Length * RATE / 1000.0; // units are in kHz
    //        }

    //        // update scottplot (PCM, time domain)
    //        scottPlotUC3.Xs = Xs;
    //        scottPlotUC3.Ys = Ys;

    //        //update scottplot (FFT, frequency domain)
    //        Ys2 = FFT(Ys);
    //        scottPlotUC4.Xs = Xs2.Take(Xs2.Length / 2).ToArray();
    //        scottPlotUC4.Ys = Ys2.Take(Ys2.Length / 2).ToArray();


    //        // update the displays
    //        scottPlotUC3.UpdateGraph();
    //        scottPlotUC4.UpdateGraph();

    //        Application.DoEvents();
    //        scottPlotUC3.Update();
    //        scottPlotUC4.Update();

    //        timer2.Enabled = true;

    //    }

    //    public double[] FFT(double[] data)
    //    {
    //        double[] fft = new double[data.Length]; // this is where we will store the output (fft)
    //        Complex[] fftComplex = new Complex[data.Length]; // the FFT function requires complex format
    //        for (int i = 0; i < data.Length; i++)
    //        {
    //            fftComplex[i] = new Complex(data[i], 0.0); // make it complex format (imaginary = 0)
    //        }
    //        Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
    //        for (int i = 0; i < data.Length; i++)
    //        {
    //            fft[i] = fftComplex[i].Magnitude; // back to double
    //            //fft[i] = Math.Log10(fft[i]); // convert to dB
    //        }
    //        return fft; this.Invoke(new EventHandler(UpdateAudioGraph));
    //        //todo: this could be much faster by reusing variables
    //    }


    public partial class Form1 : Form
    {
        public DirectSoundOut waveOut2;
        public WaveInEvent wi2;
        public BufferedWaveProvider bwp2;
        Thread in_thread; DirectSoundOut waveOut = null;
        public WaveIn wi;
        public BufferedWaveProvider bwp;
        public Int32 envelopeMax;
        ISampleProvider samples;
        private int RATE = 44100; // sample rate of the sound card
        private int BUFFERSIZE = (int)Math.Pow(2, 13); // must be a multiple of 2
                                                       //private int BUFFERSIZE = 2048; // must be a multiple of 2
        NAudio.Wave.WaveIn sourceStream = null;

        public Form1()
        {
            InitializeComponent();

            // see what audio devices are available
            int devcount = WaveIn.DeviceCount;
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);

            // create a wave buffer and start the recording
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
            bwp = new BufferedWaveProvider(wi.WaveFormat);
            //ISampleProvider samples=bwp.ToSampleProvider();
            bwp.BufferLength = BUFFERSIZE * 2;

            bwp.DiscardOnBufferOverflow = true;
            wi.StartRecording(); ;
            //waveOut = new NAudio.Wave.DirectSoundOut();
            //    waveOut.Init(samples);
            //   waveOut.Play(); 


        }

        // adds data to the audio recording buffer
        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
           
            //IWaveProvider r = new BufferedWaveProvider(wi.WaveFormat);
            //bwp.DiscardOnBufferOverflow = true;

            //bwp.Read(data,0, e.BytesRecorded);
            //var bytesPerFrame = wi.WaveFormat.BitsPerSample / 8
            //         * wi.WaveFormat.Channels;
            //var bufferedFrames = bwp.BufferedBytes / bytesPerFrame;

            //var frames = new float[bufferedFrames];
            //samples.Read(frames, 0, bufferedFrames);

        }

        public void UpdateAudioGraph()
        {
            // read the bytes from the stream
            int frameSize = BUFFERSIZE;
            var frames = new byte[frameSize];
            bwp.Read(frames, 0, frameSize);
            if (frames.Length == 0) return;
            if (frames[frameSize - 2] == 0) return;

            timer2.Enabled = false;

            // convert it to int32 manually (and a double for scottplot)
            int SAMPLE_RESOLUTION = 16;
            int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
            Int32[] vals = new Int32[frames.Length / BYTES_PER_POINT];
            double[] Ys = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs = new double[frames.Length / BYTES_PER_POINT];
            double[] Ys2 = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs2 = new double[frames.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = (int)(short)((hByte << 8) | lByte);
                Xs[i] = i;
                Ys[i] = vals[i];
                Xs2[i] = (double)i / Ys.Length * RATE / 1000.0; // units are in kHz
            }

            // update scottplot (PCM, time domain)
            scottPlotUC3.Xs = Xs;
            scottPlotUC3.Ys = Ys;

            //update scottplot (FFT, frequency domain)
            Ys2 = FFT(Ys);
            scottPlotUC4.Xs = Xs2.Take(Xs2.Length / 2).ToArray();
            scottPlotUC4.Ys = Ys2.Take(Ys2.Length / 2).ToArray();


            // update the displays
            scottPlotUC3.UpdateGraph();
            scottPlotUC4.UpdateGraph();

            Application.DoEvents();
            scottPlotUC3.Update();
            scottPlotUC4.Update();

            timer2.Enabled = true;

        }

        public double[] FFT(double[] data)
        {
            double[] fft = new double[data.Length]; // this is where we will store the output (fft)
            Complex[] fftComplex = new Complex[data.Length]; // the FFT function requires complex format
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new Complex(data[i], 0.0); // make it complex format (imaginary = 0)
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
            {
                fft[i] = fftComplex[i].Magnitude; // back to double
                                                  //fft[i] = Math.Log10(fft[i]); // convert to dB
            }
            return fft;
            //todo: this could be much faster by reusing variables
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAudioGraph();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAudioGraph();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateAudioGraph();

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateAudioGraph();
            timer2.Enabled = true;
        }
        //public void upgrate()

        //{
        //    WaveInEvent wi2 =  new WaveInEvent(); 
        //    wi2.DeviceNumber = 0;
        //    wi2.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);

        //    // create a wave buffer and start the recording
        //    wi2.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
        //    bwp2 = new BufferedWaveProvider(wi2.WaveFormat);
        //    //ISampleProvider samples=bwp.ToSampleProvider();
        //    bwp2.DiscardOnBufferOverflow = true;
        //    wi2.StartRecording();
        //    waveOut2 = new NAudio.Wave.DirectSoundOut();
        //    waveOut2.Init(bwp2);

        //    //sourceStream.StartRecording();
        //    waveOut2.Play();}






        int d = 0;
        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (wi != null)
            {
                wi.StopRecording();
                wi.Dispose();
                wi = null;
            }
            //d = trackBar1.Value;
            //sourceStream = new NAudio.Wave.WaveIn();
            //sourceStream.DeviceNumber = 0;
            //sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1); ;

            //NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);



            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(bwp);

            //sourceStream.StartRecording();
            waveOut.Play();
            //in_thread = new Thread(new ThreadStart(upgrate));
            
            //in_thread.Start();

        }
            public void button2_Click_1(object sender, EventArgs e)
            {
                //f.Hide();
                //f.Show();
            }
        
    } }