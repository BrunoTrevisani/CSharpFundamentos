using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNumericos
    {
        public void Executar()
        {
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(Int16.MaxValue);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
        }
    }
}
