using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ByteConvertor
    {
        public byte[] ToBytes(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public string ToString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        public string ToStringDefault(byte[] bytes)
        {
            return Encoding.Default.GetString(bytes);
        }
    }
}
