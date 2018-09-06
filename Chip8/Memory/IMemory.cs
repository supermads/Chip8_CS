using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8.Memory
{
    public interface IMemory
    {
        Byte ReadByte(UInt16 address);

        void WriteByte(UInt16 address, Byte data);
    }
}
