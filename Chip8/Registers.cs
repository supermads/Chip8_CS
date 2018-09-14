using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8
{
    public class Registers
    {
        public byte Delay = 0;
        public byte Sound = 0;
        public ushort I = 0;
        public byte[] V = new byte[0x10];
    }
}
