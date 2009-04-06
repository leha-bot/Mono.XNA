#region License
/*
MIT License
Copyright © 2006 The Mono.Xna Team

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

using System;

namespace Microsoft.Xna.Framework.Audio
{
    public class WaveBank : IDisposable
    {
        #region Public Events

        public event EventHandler Disposing;

        #endregion


        #region Public Properties

        public bool IsDisposed
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsInUse
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsPrepared
        {
            get { throw new NotImplementedException(); }
        }

        #endregion


        #region Constructors

        public WaveBank(AudioEngine audioEngine, string nonStreamingWaveBankFilename)
        {
            throw new NotImplementedException();
        }

        public WaveBank(AudioEngine audioEngine, string streamingWaveBankFilename, int offset, short packetsize)
        {
            throw new NotImplementedException();
        }

        #endregion Constructors


        #region Destructor

        ~WaveBank()
        {
        }

        #endregion Destructor


        #region Public Methods

        public static bool operator ==(WaveBank left, WaveBank right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(WaveBank left, WaveBank right)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Protected Methods

        protected virtual void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        protected void raise_Disposing(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        #endregion Protected Methods
    }
}
