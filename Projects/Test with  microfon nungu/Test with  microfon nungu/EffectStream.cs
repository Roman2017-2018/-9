using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
namespace Test_with__microfon_nungu
{
    public class EffectStream : WaveStream
    {
        public WaveStream SourceStream
        {
            get;
            set;
        }
        public EffectStream(WaveStream stream)
        {
            this.SourceStream = stream;
        }
        public override long Length
        {
             get { return SourceStream.Length; }
        }
        public override long Position
        {
            get { return SourceStream.Position; }
            set { SourceStream.Position = value; }
        }
        public override WaveFormat WaveFormat
        {
            get { return SourceStream.WaveFormat; }
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            return SourceStream.Read(buffer, offset, count); 
        }
    }
}
