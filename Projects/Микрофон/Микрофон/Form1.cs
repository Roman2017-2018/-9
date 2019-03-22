using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Микрофон
{
    public partial class Form1 : Form
    {
        private WaveIn recorder;
        private BufferedWaveProvider bufferedWaveProvider;
        private SavingWaveProvider savingWaveProvider;
        private DirectSoundOut player;
                 
        public Form1()
        {

            InitializeComponent();







            //Child1 sd = new Child1();

            //IA ss = new Child();
            //richTextBox1.AppendText(ss.Go());
            //ss = new Base();
            //richTextBox1.AppendText(ss.Go());
            //ss = new Child1();
            //richTextBox1.AppendText(ss.Go());
        }
      

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)
        {
            bufferedWaveProvider.AddSamples(waveInEventArgs.Buffer, 0, waveInEventArgs.BytesRecorded);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // set up the recorder
            recorder = new WaveIn();
            recorder.DataAvailable += RecorderOnDataAvailable;

            // set up our signal chain
            bufferedWaveProvider = new BufferedWaveProvider(recorder.WaveFormat);
            //savingWaveProvider = new SavingWaveProvider(bufferedWaveProvider, "temp.wav");

            // set up playback
            WaveFileReader 
            player = new DirectSoundOut(50);
            //TimeSpan error = new TimeSpan(0, 0, 0);

            //TimeSpan error1 = new TimeSpan(0, 0, 1);
            //TimeSpan error2 = new TimeSpan(1, 0, 1);
            //WaveInProvider ss = new WaveInProvider(recorder);

            //NAudio.Wave.WaveOffsetStream str = new NAudio.Wave.WaveOffsetStream(ss, error, error1, error2);

            player.Init(bufferedWaveProvider);

            // begin playback & record
            player.Play();
            recorder.StartRecording();
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
                // stop recording
                recorder.StopRecording();
                // stop playback
                player.Stop();
                // finalise the WAV file
                savingWaveProvider.Dispose();
        }
    }

    class SavingWaveProvider : IWaveProvider, IDisposable
    {
        private readonly IWaveProvider sourceWaveProvider;
        private readonly WaveFileWriter writer;
        private bool isWriterDisposed;

        public SavingWaveProvider(IWaveProvider sourceWaveProvider, string wavFilePath)
        {
            this.sourceWaveProvider = sourceWaveProvider;
            writer = new WaveFileWriter(wavFilePath, sourceWaveProvider.WaveFormat);
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            var read = sourceWaveProvider.Read(buffer, offset, count);
            if (count > 0 && !isWriterDisposed)
            {
                writer.Write(buffer, offset, read);
            }
            if (count == 0)
            {
                Dispose(); // auto-dispose in case users forget
            }
            return read;
        }

        public WaveFormat WaveFormat { get { return sourceWaveProvider.WaveFormat; } }

        public void Dispose()
        {
            if (!isWriterDisposed)
            {
                isWriterDisposed = true;
                writer.Dispose();
            }
        }
    }
    
    
//    public interface IA<T> { string Go ( ); }
//    public  class Base<T> : IA<T>
//where T : new () 
//    {

//        T gr = new T();
//        public T dewewew<T> (T rre) { return rre; }
//    public string Go()    {

//        return "Base";
//        Child<int> tr = new Child<int>();
//        tr.ttt = new Child1(); ;
          
//    }
       
//    }
//    public class Child<T> : Base<T>,IA<T> 

   //{
   //     public IA ttt {  get; set; }

   //     public string Go()
   //     {
   //         return " Child";
            
   //     }

   // }
    //public class Child1 : IA
    //{

    //    public string Go()
    //    {
    //        return " Child1";
    //    }
    //}
}
