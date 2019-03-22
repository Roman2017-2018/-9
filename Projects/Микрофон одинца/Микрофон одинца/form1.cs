using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Микрофон_одинца
{
    public partial class Form1 : Form , IComparable
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NAudio.Wave.BlockAlignReductionStream stream  = null;
        private NAudio.Wave.DirectSoundOut gavnout = null;
        public int CompareTo(object ofo)
        { return 0; }
        
       private void button1_Click(object sender, EventArgs e)
        {/*Array.Sort();*/
            
           OpenFileDialog OPPOEpe = new OpenFileDialog();
            OPPOEpe.Filter = "Wawe file (*.mp3|*mp3;) ";
            if (OPPOEpe.ShowDialog() != DialogResult.OK) return;
            DisposeWave();
            NAudio.Wave.WaveStream p = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(OPPOEpe.FileName));
            button1.Text = p.WaveFormat.ToString(); 
        
            stream = new NAudio.Wave.BlockAlignReductionStream(p);
           
            TimeSpan error = new TimeSpan(0,0,0);

            TimeSpan error1 = new TimeSpan(0, 0, 1);
            TimeSpan error2 = new TimeSpan(1, 0, 1);

            NAudio.Wave.WaveOffsetStream str = new NAudio.Wave.WaveOffsetStream(stream,error,error1,error2);
            gavnout = new NAudio.Wave.DirectSoundOut();
            str.Skip(100);
          
            gavnout.Init(str);
            
            gavnout.Play();
        }

        private void DisposeWave()
        {   if (gavnout!=null)
            {   if (gavnout.PlaybackState == NAudio.Wave.PlaybackState.Playing) gavnout.Stop();
            gavnout.Dispose();
            gavnout = null;
            }
            if(stream!= null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gavnout.PlaybackState == NAudio.Wave.PlaybackState.Playing) gavnout.Pause();
            else gavnout.Play();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }
    }
}
