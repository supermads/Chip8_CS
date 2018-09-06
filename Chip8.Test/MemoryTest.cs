using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chip8.Memory;

namespace Chip8.Test
{
    [TestClass]
    public class MemoryTest
    {
        [TestMethod]
        public void ReadWriteByteSuccess()
        {
            Byte expectedByte = 0x55;
            UInt16 address = 0x400;

            IMemory memory = new Memory.Memory();
            memory.WriteByte(address, expectedByte);

            Byte actualByte = memory.ReadByte(address);

            Assert.AreEqual(expectedByte, actualByte, $"Expected {expectedByte} found {actualByte}");
        }
    }
}
