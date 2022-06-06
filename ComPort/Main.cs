using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComPort comPort = new ComPort();
            comPort.Start();

            while (true)
            {
               Console.ReadLine();
               ComPort.Write();
                
            }
        }
    }
}
