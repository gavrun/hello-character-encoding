using System;
using System.IO;

namespace writesomebytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes1 = new byte[128];

            for (byte i = 0; i < 128; i++)
            {
                bytes1[i] = i;
            }
            File.WriteAllBytes("128bytes.txt",bytes1);

            byte[] bytes2 = new byte[256];

            for (int i = 0; i < 256; i++)
            {
                bytes2[i] = (byte)i;
            }
            File.WriteAllBytes("256bytes.txt", bytes2);

            byte[] bytes3 = new byte[260];

            bytes3[0] = 0xEF;
            bytes3[1] = 0xBB;
            bytes3[2] = 0xBF;

            for (int i = 3; i < 260; i++)
            {
                bytes3[i] = (byte)i;
            }
            File.WriteAllBytes("256bytesBOM.txt", bytes3);

        }
    }
}
