using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8.Memory
{
    public class Memory : IMemory
    {
        byte[] memory = new byte[0x1000];

        public byte ReadByte(ushort address)
        {
            return memory[address];
        }

        public void WriteByte(ushort address, byte data)
        {
            memory[address] = data;
        }
    }
}
