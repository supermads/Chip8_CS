using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8.Memory
{
    public class Memory : IMemory
    {
        byte[] array = new byte[0x1000];

        public byte ReadByte(ushort address)
        {
            return array[address];
        }

        public void WriteByte(ushort address, byte data)
        {
            array[address] = data;
        }
    }
}
