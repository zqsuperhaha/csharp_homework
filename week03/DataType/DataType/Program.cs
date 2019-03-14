using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sbyte的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}",typeof(sbyte),sizeof(sbyte),sbyte.MaxValue,sbyte.MinValue);
            Console.WriteLine("byte的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(byte), sizeof(byte), byte.MaxValue, byte.MinValue);
            Console.WriteLine("short的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(short), sizeof(short), short.MaxValue, short.MinValue);
            Console.WriteLine("ushort的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(ushort), sizeof(ushort), ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("int的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(int), sizeof(int), int.MaxValue, int.MinValue);
            Console.WriteLine("uint的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(uint), sizeof(uint), uint.MaxValue, uint.MinValue);
            Console.WriteLine("long的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(long), sizeof(long), long.MaxValue, long.MinValue);
            Console.WriteLine("ulong的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(ulong), sizeof(ulong), ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("float的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(float), sizeof(float), float.MaxValue, float.MinValue);
            Console.WriteLine("double的CTS数据类型为:{0},占用的字节数为:{1},最大值为:{2},最小值为:{3}", typeof(double), sizeof(double), double.MaxValue, double.MinValue);
        }
    }
}
