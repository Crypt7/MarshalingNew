using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace MarshalingNew
{
    class Program
    {
        private const string DllName = @"..\..\..\Debug\nfuncs.dll";
       
        [DllImport(DllName)]
        public static extern int Add(int a, int b);
        static void Main(string[] args)
        {
            int a = 30;
            int b = 10;
            int Sum = Program.Add(a, b);
            Console.WriteLine(Sum);
        }
    }
}
