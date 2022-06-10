namespace ComPort
{
    internal class Program
    {
        private static void Main(string[] args)
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
