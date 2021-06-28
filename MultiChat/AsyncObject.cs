using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace MultiChat
{
    public class AsyncObject
    {
        private byte[] buffer;
        private Socket workingSocket;
        private readonly int bufferSize;

        public byte[] Buffer { get => buffer; set => buffer = value; }
        public Socket WorkingSocket { get => workingSocket; set => workingSocket = value; }

        public int BufferSize => bufferSize;

        public AsyncObject(int bufferSize)
        {
            this.bufferSize = bufferSize;
            this.Buffer = new byte[this.bufferSize];
        }

        public void ClearBuffer()
        {
            Array.Clear(Buffer, 0, BufferSize);
        }
    }
}
