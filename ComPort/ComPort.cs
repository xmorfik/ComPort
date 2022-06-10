using System.IO.Ports;


namespace ComPort
{
    public class ComPort
    {
        private const int defaultSize = 24;
        private static int bufferSizeRead = defaultSize;
        private static int bufferSizeWrite = defaultSize;
        private static byte[] bufferRead = new byte[bufferSizeRead];
        private static byte[] bufferWrite = new byte[bufferSizeWrite];
        private static SerialPort _serialPort = new SerialPort();
        public void Start()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            _serialPort.PortName = SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            SetBufferRead();
            SetBufferWrite();


        }
        public static void Write()
        {
            _serialPort.Write(bufferWrite, 0, bufferSizeWrite);
        }
        public static void Stop()
        {
            _serialPort.Close();
        }
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            sp.Read(bufferRead, 0, bufferSizeRead);
            Console.WriteLine(BitConverter.ToString(bufferRead));
            Array.Clear(bufferRead, 0, bufferSizeRead);
            sp.DiscardInBuffer();
        }
        public static string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
            portName = Console.ReadLine();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }
        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;

            Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
            baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }
        public static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
            parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        public static int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
            dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }
        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;

            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter StopBits value (None is not supported and \n" +
             "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
            stopBits = Console.ReadLine();

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }
        public static void SetBufferRead()
        {
            Console.Write("Set buffer size read:");
            int newBufferSize = defaultSize;
            try
            {
                newBufferSize = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
                SetBufferRead();
            }
            Array.Resize(ref bufferRead, newBufferSize);
            bufferSizeRead = newBufferSize;
        }
        public static void SetBufferWrite()
        {
            Console.Write("Set buffer size write:");
            int newBufferSize = int.Parse(Console.ReadLine());
            Array.Resize(ref bufferWrite, newBufferSize);
            bufferSizeWrite = newBufferSize;
        }
    }
}
